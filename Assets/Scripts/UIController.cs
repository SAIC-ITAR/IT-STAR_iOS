using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

	public GameObject smallMenuOcc;
	public GameObject largeMenuOcc;
	public GameObject congrats;
	public GameObject close;
	public GameObject laptopBorder;
	public GameObject mainMarkerCanvas;
	public GameObject ARCamera;
	public GameObject[] Models = new GameObject[7];
	public Canvas[] NamePlates = new Canvas[7];
	public Material BlueMaterial;
	public Material DimBlue;
	public AudioSource soundPlayer;
	public AudioListener sound;
	public Animator anim1;
	public Animator anim2;
	public TouchController touchController;
	public ButtonControl buttonControl;
	public TestController testController;
	public string[][] Facts;
	public int factIndex = 0;
	public int lastMenuOn = 0;
	public Text MuteText;
	public Text infoText;
	public int repairCounter;
	public AudioClip abouton;
	public AudioClip repair;
	public AudioClip assessment; 
	public ParticleSystem particlesystem;
	public ParticleSystem particlesystem1;
	public ParticleSystem particlesystem2;
	public ParticleSystem particlesystem3;
	public ParticleSystem particlesystem4;
	public GameObject preparationSteps;
	public GameObject frameText;
	public GameObject instructionsText;
	public GameObject marker;
	public Collider hdRaycast;
	public Collider cdRaycast;
	public Collider ramRaycast;
	public Collider wifiRaycast;
	public Collider fanRaycast;
	public Collider batteryRaycast; 

	// Use this for initialization
	void Start () {
		//preparationText = GameObject.Find("Preparation Steps").GetComponent<Text>();
		infoText = GameObject.Find("InfoText").GetComponent<Text>();
		//preparationHeading = GameObject.Find("Preparation Heading").GetComponent<Text>();

		anim1.SetBool ("panelLeft", false);
		anim2.SetBool ("instructionsUp", false);
		//mainMarkerCanvas.GetComponent<Canvas> ().enabled = false;
		//infoText.enabled = false;
		hdRaycast = GameObject.Find("HD_Raycast target").GetComponent<BoxCollider>();
		cdRaycast = GameObject.Find("CD_Raycast target").GetComponent<BoxCollider>();
		ramRaycast = GameObject.Find("RAM_Raycast target").GetComponent<BoxCollider>();
		wifiRaycast = GameObject.Find("WiFi_Raycast target").GetComponent<BoxCollider>();
		fanRaycast = GameObject.Find("Fan_Raycast target").GetComponent<BoxCollider>();
		batteryRaycast = GameObject.Find("Battery_Raycast target").GetComponent<BoxCollider>(); 

	}



	//----------------------------------------------------------------Button fuctions-------------------------------------------------------------------------------------------
	public void Quit(){
		if (buttonControl.userGuidePanel.activeSelf) {
			buttonControl.userGuideOn (false);
		} else {
			Application.Quit ();
		}
	}
		
	public void AboutOn(){
		mainMarkerCanvas.GetComponent<Canvas> ().enabled = true;
		infoText.enabled = true;
		//preparationText.enabled = false;
		//preparationHeading.enabled = false;
		touchController.FirstMenu = false;
		Facts = StringPool.AFacts;
		mainMarkerCanvas.GetComponentInChildren<Text> ().text = Facts [touchController.menuOn] [0];
		factIndex = 0;
		soundPlayer.clip = abouton;
		soundPlayer.Play();
		buttonControl.removeFirstMenu ();

	}  

	//tutorial instructions
	public void RepairOn(){
		 
		repairCounter = 1;
		mainMarkerCanvas.GetComponent<Canvas> ().enabled = true;
		infoText.enabled = true;
		//preparationText.enabled = false;
		//preparationHeading.enabled = false;
		touchController.FirstMenu = false;
		Facts = StringPool.RFacts;
		mainMarkerCanvas.GetComponentInChildren<Text> ().text = Facts [touchController.menuOn][0];
		factIndex = 0;
		soundPlayer.clip =repair;
		soundPlayer.Play ();
		buttonControl.removeFirstMenu ();
		testController.Glow [touchController.menuOn].enabled = false;


		touchController.batteryRenderer.enabled = false;
		touchController.cdRenderer.enabled = false;
		touchController.fanRenderer.enabled = false;
		touchController.hdRenderer.enabled = false;
		touchController.ramRenderer.enabled = false;
		touchController.wifiRenderer.enabled = false;

		for (int i = 1;i < testController.Glow.Length;i++) {
			NamePlates[i].enabled = false;
		}
		}

	public void left(){


		if (repairCounter > 0) {
			repairCounter -= 1;
		}


		if (factIndex > 0) {
			factIndex--;
			mainMarkerCanvas.GetComponentInChildren<Text> ().text = Facts [touchController.menuOn][factIndex];
		}
		if (factIndex == 0) {
				buttonControl.LeftOn (false);
		}
		if (factIndex == Facts[touchController.menuOn].Length - 2) {
				buttonControl.rightOn (true);
		}
	}

	public void right(){

		if (repairCounter > 0) {
			repairCounter++;
		}


		if (factIndex <  Facts[touchController.menuOn].Length - 1) {
			factIndex++;
			mainMarkerCanvas.GetComponentInChildren<Text> ().text = Facts [touchController.menuOn][factIndex];
		}
		if (factIndex == Facts [touchController.menuOn].Length - 1) {
				buttonControl.rightOn (false);
		}
		if (factIndex == 1) {
				buttonControl.LeftOn (true);
		}
	}







	public void TestOn () {
		soundPlayer.clip =assessment;
		soundPlayer.Play ();
		anim1.SetBool ("testOn", true);
		touchController.FirstMenu = false;
		testController.TestOn (touchController.menuOn);
		largeMenuOcc.SetActive (true);
	}

	public void Back(){
		if (touchController.FirstMenu) {
			anim1.SetBool ("panelRight", true);
			anim2.SetBool ("instructionsUp", false);
			testController.Glow [touchController.menuOn].enabled = true;
			testController.undim ();
			touchController.menuOn = 0;
			smallMenuOcc.SetActive (false);

		} else {
			repairCounter = 0;
			if (anim1.GetBool ("testOn") && testController.qNumber < 4) {
				testController.scores [touchController.menuOn] = -1;
			}
			anim1.SetBool ("testOn", false);
			mainMarkerCanvas.GetComponent<Canvas> ().enabled = false;
			touchController.FirstMenu = true;
			buttonControl.bringFirstMenu ();
			testController.Glow [touchController.menuOn].enabled = true;
			//testController.Glow [touchController.menuOn].material = BlueMaterial;
			for (int i = 1;i < testController.Glow.Length;i++) {
				NamePlates[i].enabled = true;
			}
			largeMenuOcc.SetActive (false);

			for (int i = 1; i < 7; i++) {
				if (testController.scores [i] != 4 + StringPool.RFacts [i].Length) {
					break;
				}
				if (i == 6) {
					particlesystem.Play ();
					particlesystem1.Play ();
					particlesystem2.Play ();
					particlesystem3.Play ();
					particlesystem4.Play ();
					congrats.SetActive (true);
					close.SetActive (true);
				}
			}

			//makes sure that the correct model is active, if turned off in the repair section
			switch (touchController.menuOn) {
			case 1: //Battery
				touchController.batteryRenderer.enabled = true;
				break;
			case 2: //CD Drive
				touchController.cdRenderer.enabled = true;
				break;
			case 3: //Fan Assembly
				touchController.fanRenderer.enabled = true;
				break;
			case 4: //Hard Drive
				touchController.hdRenderer.enabled = true;
				break;
			case 5: //RAM
				touchController.ramRenderer.enabled = true;
				break;
			case 6: //WiFi
				touchController.wifiRenderer.enabled = true;
				break;
			}
		}
	}

	public void AudioClick1(){
		soundPlayer.Play ();
	}

	public void mute() {
		if (AudioListener.pause){
			AudioListener.pause = false;
			MuteText.text = "Mute";

		}
		else{
			AudioListener.pause = true;
			MuteText.text = "Unmute";
		}
	}

	public void ScoreReset(){
		for (int i = 1; i < 7; i++) {
			testController.Glow [i].material = BlueMaterial;
			testController.scores [i] = -1;
		}
	}




	public void screwOn () {
		if (touchController.menuOn == 0){
		mainMarkerCanvas.GetComponent<Canvas> ().enabled = !mainMarkerCanvas.GetComponent<Canvas> ().enabled;
		infoText.enabled = !infoText.enabled;
			preparationSteps.SetActive (!preparationSteps.activeSelf);
		//preparationHeading.enabled = !preparationHeading.enabled;
		}
	}

	public void closeCongrats () {
		congrats.SetActive (false);
		close.SetActive (false);
		for (int i = 1; i < 7; i++) {
			testController.Glow [i].material = testController.DimGreenMaterial;
		}
	}

	public void trackingVisualsOn (bool b) {
		/*for (int i = 1;i < testController.Glow.Length;i++) {
			testController.Glow[i].enabled = b;
		}

		for (int i = 1;i < testController.Glow.Length;i++) {
			NamePlates[i].enabled = b;
		}*/
		if (b == false) {
			ARCamera.transform.position = new Vector3 (-3511f, -575f, 564f);
			ARCamera.transform.LookAt (marker.transform);
			//47, 180, 5
			hdRaycast.enabled = true;
			cdRaycast.enabled = true;
			fanRaycast.enabled = true;
			batteryRaycast.enabled = true;
			ramRaycast.enabled = true;
			wifiRaycast.enabled = true; 

		}
		laptopBorder.SetActive (!b);
		frameText.SetActive (!b);
		instructionsText.SetActive (b);
		/*if (!b && anim1 != null) {
			mainMarkerCanvas.GetComponent<Canvas> ().enabled = false;
			for (int i = 1;i < Models.Length;i++) {
				Models[i].GetComponent<Renderer> ().enabled = false;
			}
			if(anim1.GetBool("testOn")){
				testController.scores [touchController.menuOn] = -1;
			}
			if (touchController.menuOn != 0) {
				testController.undim ();
			}
			touchController.menuOn = 0;
			touchController.FirstMenu = true;
			anim1.SetBool("testOn", false);
			anim1.SetBool ("panelRight", true);
			anim2.SetBool ("instructionsUp", false);
			buttonControl.bringFirstMenu ();
			smallMenuOcc.SetActive (false);
			largeMenuOcc.SetActive (false);
		}*/
	}


	// Update is called once per frame

	void Update () {


		if (Input.GetKeyDown("f")){
		particlesystem.Play ();
		particlesystem1.Play ();
		particlesystem2.Play ();
		particlesystem3.Play ();
		particlesystem4.Play ();
		congrats.SetActive (true);
		close.SetActive (true);
	}


		if ((touchController.menuOn != lastMenuOn) && (lastMenuOn  != 0) && (!anim1.GetBool ("testOn"))) {
			mainMarkerCanvas.GetComponent<Canvas> ().enabled = false;
			if (!touchController.FirstMenu) {
				buttonControl.bringFirstMenu ();
			}
		}
		if (touchController.menuOn != lastMenuOn) {
			testController.Glow [lastMenuOn].enabled = true;
			touchController.FirstMenu = true;
			lastMenuOn = touchController.menuOn;
			repairCounter = 0;
		}
	}
}
	