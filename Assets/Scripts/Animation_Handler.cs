using UnityEngine;
using System.Collections;

public class Animation_Handler : MonoBehaviour {

	public UIController uiController;
	public TouchController touchController;
	public Animator arrow1Anim;
	public Animator arrow2Anim;
	public Animator Screw1Controller;
	public Animator Screw2Controller;
	public Animator Screw3Controller;
	public Animator Screw4Controller;
	public Animator Screw5Controller;
	public Animator Screw6Controller;
	public Animator hdAnim;
	public Animator cdAnim;
	public Animator ramAnim;
	public Animator batteryAnim;
	public Animator wifiAnim;
	public Animator fanAnim;
	public MeshRenderer arrow1Renderer;
	public MeshRenderer arrow2Renderer;
	public MeshRenderer screw1Renderer;
	public MeshRenderer screw2Renderer;
	public MeshRenderer screw3Renderer;
	public MeshRenderer screw4Renderer;
	public MeshRenderer screw5Renderer;
	public MeshRenderer screw6Renderer;
	public int menuOnLast;
	public TestController testController;


	void Start(){
		batteryAnim.SetInteger ("Battery_State", 0);
		ramAnim.SetInteger ("RAM_State", 0);
		cdAnim.SetInteger ("CD_State", 0);
		hdAnim.SetInteger ("HD_State", 0);
		wifiAnim.SetInteger ("WiFi_State", 0);
		fanAnim.SetInteger ("Fan_State", 0);
	}



	void Update () {

		//Debug.Log ("arrow state:" +  arrow1Anim.GetInteger ("arrow1State"));


		if (Input.GetKeyDown("a")){
			Debug.Log("menuOn is:" + menuOnLast);
		}


		/*this controls the animator.  It checks the menuOn variable, which stores the current active component.
			It then checks the state of repairCounter, which is incremented by the arrow buttons. This is done in the UIController
			It then sets the state of arrow1, arrow2 and screws 1-6
		  */
		if (touchController.menuOn == 1) {
			arrow1Anim.SetInteger ("arrow1Base", 1);
			//batteryAnim.SetInteger ("Battery_State", 0);

			switch (uiController.repairCounter) {
			case 0:
				batteryAnim.SetInteger ("Battery_State", 0);
				arrow1Anim.SetInteger ("arrow1State", 0);
				arrow2Anim.SetInteger ("arrow2State", 0);
				break;
			case 1:
				batteryAnim.SetInteger ("Battery_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 1);
				arrow2Anim.SetInteger ("arrow2State", 0);
				break;
			case 2:
				batteryAnim.SetInteger ("Battery_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 2);
				arrow2Anim.SetInteger ("arrow2State", 1);
				break;
			case 3:
				batteryAnim.SetInteger ("Battery_State", 2);
				arrow1Anim.SetInteger ("arrow1State", 3);
				arrow2Anim.SetInteger ("arrow2State", 0);
				break;
			case 4:
				batteryAnim.SetInteger ("Battery_State", 3);
				arrow1Anim.SetInteger ("arrow1State", 4);
				break;
			}
		}
			else if (touchController.menuOn == 2) {
			arrow1Anim.SetInteger ("arrow1Base", 2);
			cdAnim.SetInteger ("CD_State", 1);

			switch (uiController.repairCounter) {

			case 0:
				arrow1Anim.SetInteger ("arrow1State", 0);
				cdAnim.SetInteger ("CD_State", 0);

				break;
			case 1:
				arrow1Anim.SetInteger ("arrow1State", 1);
				arrow2Anim.SetInteger ("arrow2State", 0);
				cdAnim.SetInteger ("CD_State", 1);

				break;
			case 2:
				arrow1Anim.SetInteger ("arrow1State", 2);
				arrow2Anim.SetInteger ("arrow2State", 0);
				cdAnim.SetInteger ("CD_State", 1);

				break;
			case 3:
				arrow1Anim.SetInteger ("arrow1State", 3);
				arrow2Anim.SetInteger ("arrow2State", 2);
				cdAnim.SetInteger ("CD_State", 2);

				break;
			case 4:
				arrow1Anim.SetInteger ("arrow1State", 4);
				cdAnim.SetInteger ("CD_State", 1);
				arrow2Anim.SetInteger ("arrow2State", 0);
				break;
			}
			}
		else if (touchController.menuOn == 3) {
			arrow1Anim.SetInteger ("arrow1Base", 3);
			fanAnim.SetInteger ("Fan_State", 0);

			switch (uiController.repairCounter) {

			case 0:
				arrow1Anim.SetInteger ("arrow1State", 0);
				fanAnim.SetInteger ("Fan_State", 0);
				break;
			case 1:
				arrow1Anim.SetInteger ("arrow1State", 1);
				fanAnim.SetInteger ("Fan_State", 1);
				break;
			case 2:
				fanAnim.SetInteger ("Fan_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 3);
				Screw1Controller.SetInteger ("Screw1State", 1);
				Screw2Controller.SetInteger ("Screw2State", 1);
				Screw3Controller.SetInteger ("Screw3State", 1);
				Screw4Controller.SetInteger ("Screw4State", 1);
				Screw5Controller.SetInteger ("Screw5State", 1);
				break;
			case 3:
				fanAnim.SetInteger ("Fan_State", 2);
				arrow1Anim.SetInteger ("arrow1State", 4);
				Screw1Controller.SetInteger ("Screw1State", 0);
				Screw2Controller.SetInteger ("Screw2State", 0);
				Screw3Controller.SetInteger ("Screw3State", 0);
				Screw4Controller.SetInteger ("Screw4State", 0);
				Screw5Controller.SetInteger ("Screw5State", 0);
				break;
			case 4:
				fanAnim.SetInteger ("Fan_State", 4);
				arrow1Anim.SetInteger ("arrow1State", 5);
				Screw1Controller.SetInteger ("Screw1State", 0);
				Screw2Controller.SetInteger ("Screw2State", 0);
				Screw3Controller.SetInteger ("Screw3State", 0);
				Screw4Controller.SetInteger ("Screw4State", 0);
				Screw5Controller.SetInteger ("Screw5State", 0);
				break;
			case 5:
				fanAnim.SetInteger ("Fan_State", 3);
				arrow1Anim.SetInteger ("arrow1State", 6);
				break;
			case 6:
				fanAnim.SetInteger ("Fan_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 7);
				Screw1Controller.SetInteger ("Screw1State", 2);
				Screw2Controller.SetInteger ("Screw2State", 2);
				Screw3Controller.SetInteger ("Screw3State", 2);
				Screw4Controller.SetInteger ("Screw4State", 2);
				Screw5Controller.SetInteger ("Screw5State", 2);
				break;
			case 7:
				fanAnim.SetInteger ("Fan_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 7);
				Screw1Controller.SetInteger ("Screw1State", 1);
				Screw2Controller.SetInteger ("Screw2State", 1);
				Screw3Controller.SetInteger ("Screw3State", 1);
				Screw4Controller.SetInteger ("Screw4State", 1);
				Screw5Controller.SetInteger ("Screw5State", 1);
				break;
			}
		}else if (touchController.menuOn == 4) {
			arrow1Anim.SetInteger ("arrow1Base", 4);
			hdAnim.SetInteger ("HD_State", 0);

			switch (uiController.repairCounter) {

			case 0:
				arrow1Anim.SetInteger ("arrow1State", 0);
				hdAnim.SetInteger ("HD_State", 0);

				break;
			case 1:
				arrow1Anim.SetInteger ("arrow1State", 1);
				hdAnim.SetInteger ("HD_State", 1);

				break;
			case 2:
				arrow1Anim.SetInteger ("arrow1State", 2);
				hdAnim.SetInteger ("HD_State", 2);

				break;
			case 3:
				arrow1Anim.SetInteger ("arrow1State", 3);
				hdAnim.SetInteger ("HD_State", 3);

				break;


			}
		}else if (touchController.menuOn == 5) {
			arrow1Anim.SetInteger ("arrow1Base", 5);
			ramAnim.SetInteger ("RAM_State", 0);

			switch (uiController.repairCounter) {

			case 0:
				ramAnim.SetInteger ("RAM_State", 0);
				arrow1Anim.SetInteger ("arrow1State", 0);
				break;
			case 1:
				ramAnim.SetInteger ("RAM_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 1);
				arrow2Anim.SetInteger ("arrow2State", 0);

				break;
			case 2:
				ramAnim.SetInteger ("RAM_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 2);
				arrow2Anim.SetInteger ("arrow2State", 3);

				break;
			case 3:
				ramAnim.SetInteger ("RAM_State", 2);
				arrow1Anim.SetInteger ("arrow1State", 3);
				arrow2Anim.SetInteger ("arrow2State", 0);

				break;
			case 4:
				ramAnim.SetInteger ("RAM_State", 3);
				arrow1Anim.SetInteger ("arrow1State", 4);
				break;
			case 5:
				ramAnim.SetInteger ("RAM_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 5);
				break;
			}
		}
		else if (touchController.menuOn == 6) {
			arrow1Anim.SetInteger ("arrow1Base", 6);
			wifiAnim.SetInteger ("WiFi_State", 0);

			switch (uiController.repairCounter) {

			case 0:
				wifiAnim.SetInteger ("WiFi_State", 0);
				arrow1Anim.SetInteger ("arrow1State", 0);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			case 1:
				wifiAnim.SetInteger ("WiFi_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 1);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			case 2:
				wifiAnim.SetInteger ("WiFi_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 2);
				Screw6Controller.SetInteger ("Screw6State", 1);
				Screw6Controller.SetInteger ("Screw6State", 1);

				break;
			case 3:
				wifiAnim.SetInteger ("WiFi_State", 2);
				arrow1Anim.SetInteger ("arrow1State", 3);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			case 4:
				wifiAnim.SetInteger ("WiFi_State", 3);
				arrow1Anim.SetInteger ("arrow1State", 4);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			case 5:
				wifiAnim.SetInteger ("WiFi_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 5);
				Screw6Controller.SetInteger ("Screw6State", 2);

				break;
			case 6:
				wifiAnim.SetInteger ("WiFi_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 6);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			case 7:
				wifiAnim.SetInteger ("WiFi_State", 1);
				arrow1Anim.SetInteger ("arrow1State", 6);
				Screw6Controller.SetInteger ("Screw6State", 0);

				break;
			}
		}


		//resets the animator if a different object is selected

		if ((touchController.menuOn == 0) || (menuOnLast != touchController.menuOn) || (uiController.repairCounter == 0)) {


			arrow1Anim.SetInteger ("arrow1State", 0);
			arrow1Anim.SetInteger ("arrow1Base", 0);
			arrow2Anim.SetInteger ("arrow2State", 0);
			Screw1Controller.SetInteger ("Screw1State", 0);
			Screw2Controller.SetInteger ("Screw2State", 0);
			Screw3Controller.SetInteger ("Screw3State", 0);
			Screw4Controller.SetInteger ("Screw4State", 0);
			Screw5Controller.SetInteger ("Screw5State", 0);
			Screw6Controller.SetInteger ("Screw6State", 0);
			batteryAnim.SetInteger ("Battery_State", 0);
			ramAnim.SetInteger ("RAM_State", 0);
			cdAnim.SetInteger ("CD_State", 0);
			hdAnim.SetInteger ("HD_State", 0);
			wifiAnim.SetInteger ("WiFi_State", 0);
			fanAnim.SetInteger ("Fan_State", 0);


		}


		//resets the animator if the back button is pressed--- repairCounter is set to 0 in the Back function of the UIController

		if (uiController.repairCounter > 0) {
			arrow1Renderer.enabled = true;
			arrow2Renderer.enabled = true;
			screw1Renderer.enabled = true;
			screw2Renderer.enabled = true;
			screw3Renderer.enabled = true;
			screw4Renderer.enabled = true;
			screw5Renderer.enabled = true;
			screw6Renderer.enabled = true;

		}




		//this stores the menuOn info at the end of the frame, as far as the animator is concerned
		menuOnLast = touchController.menuOn;


			}


		}




