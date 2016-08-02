using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchController : MonoBehaviour {


	public AudioSource sound;
	public Animator anim1;
	public Animator anim2;
	public GameObject userGuide;
	public Renderer hdRenderer;
	public Renderer ramRenderer;
	public Renderer cdRenderer;
	public Renderer fanRenderer;
	public Renderer batteryRenderer;
	public Renderer wifiRenderer;
	public int menuOn;
	public int lastMenuOn;
	public bool FirstMenu;
	public UIController uiController;
	public int justStart;
	public Image preparationButton;
	public TestController testController;


	void Awake (){

		preparationButton = GameObject.Find("Preparation Instructions Button").GetComponent<Image>();
		menuOn = 0;
		lastMenuOn = 42;
		FirstMenu = true;
	}

	public void onTap () {//Stuff that happens for any model when it is tapped (or its key is pressed)
		justStart++;
		anim1.SetBool ("panelLeft", true);
		anim1.SetBool ("panelRight", false);
		anim2.SetBool ("instructionsUp", true);
		uiController.smallMenuOcc.SetActive (true);
		testController.dim (menuOn);
	}


	void Update () {

		 
		if (menuOn != 0) {
			preparationButton.enabled = false;
		} else 
		{
			preparationButton.enabled = true;
		}

		if (!userGuide.activeSelf && !anim1.GetBool ("testOn")) {

			if (Input.GetKeyDown ("q")) {
				menuOn = 1;
				onTap ();
			} else if (Input.GetKeyDown ("w")) {
				menuOn = 2;
				onTap ();
			} else if (Input.GetKeyDown ("e")) {
				menuOn = 3;
				onTap ();
			} else if (Input.GetKeyDown ("r")) {
				menuOn = 4;
				onTap ();
			} else if (Input.GetKeyDown ("t")) {
				menuOn = 5;
				onTap ();
			} else if (Input.GetKeyDown ("y")) {
				menuOn = 6;
				onTap ();
			}
		}

		//get touch input
		Touch myTouch;

		//Touch[] myTouches = Input.touches;

		for (int i = 0; i < Input.touchCount; i++) {
			myTouch = Input.GetTouch (i);
			if (myTouch.phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay (myTouch.position);
				RaycastHit hit;
				Physics.Raycast (ray, out hit);

				if (!userGuide.activeSelf && !anim1.GetBool ("testOn")) {

					//touch hard drive
					if ((hit.rigidbody.gameObject.name == "HD_Raycast target")) {
						menuOn = 4;
						onTap ();
					}
					//touch ram 
					else if ((hit.rigidbody.gameObject.name == "RAM_Raycast target")) {
						menuOn = 5;
						onTap ();
					} else if ((hit.rigidbody.gameObject.name == "WiFi_Raycast target")) {
						menuOn = 6;
						onTap ();
					} else if ((hit.rigidbody.gameObject.name == "Battery_Raycast target")) {
						menuOn = 1;
						onTap ();
					} else if ((hit.rigidbody.gameObject.name == "CD_Raycast target")) {
						menuOn = 2;
						onTap ();
					} else if ((hit.rigidbody.gameObject.name == "Fan_Raycast target")) {
						menuOn = 3;
						onTap ();
					}
				}
			}
		}

		if (menuOn != lastMenuOn) {
			batteryRenderer.enabled = false;
			cdRenderer.enabled = false;
			fanRenderer.enabled = false;
			hdRenderer.enabled = false;
			ramRenderer.enabled = false;
			wifiRenderer.enabled = false;

			switch (menuOn) {
			case 1: //Battery
				batteryRenderer.enabled = true;
				break;
			case 2: //CD Drive
				cdRenderer.enabled = true;
				break;
			case 3: //Fan Assembly
				fanRenderer.enabled = true;
				break;
			case 4: //Hard Drive
				hdRenderer.enabled = true;
				break;
			case 5: //RAM
				ramRenderer.enabled = true;
				break;
			case 6: //WiFi
				wifiRenderer.enabled = true;
				break;
			}
			lastMenuOn = menuOn;
		}


		//this checks if the app has just started, and turns on the preparation text until a component is selected
		if (justStart == 1) {
			justStart++;
			uiController.infoText.enabled = true;
			//uiController.preparationText.enabled = false;
			//uiController.preparationHeading.enabled = false;
			uiController.mainMarkerCanvas.GetComponent<Canvas> ().enabled = false;		
		}
	}



}