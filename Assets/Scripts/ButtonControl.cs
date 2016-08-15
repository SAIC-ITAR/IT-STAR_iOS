using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
	//This class is responsible for controlling all the buttons by turning their activity true or false. These methods are called when methods inside the UI Controller class are called bt a button press.
	public GameObject about;//about button on panel
	public GameObject repair;//repair button on panel
	public GameObject test;//test button on panel
	public GameObject back;//back button on panel
	public GameObject next;//next button when in the assessment
	public GameObject left;//left arrow when in assessment
	public GameObject right;//right arrow when in assessment
	public GameObject up; // up arrow during ordering section of test
	public GameObject down; // down arrow during ordering section of test
	public GameObject[] answer = new GameObject[7];//answers in assessment
	public GameObject question;//the question that is asked in assessment
	public GameObject optionsPanel;//the panel that appears when the options gears in the upper left are pressed
	public GameObject userGuidePanel;//the panel that appears when the user guide button is pressed under the options gear
	public GameObject ITtext; //IT-Star text
	public GameObject menuOccluder; //occludes objects behind the options menu
	public UIController uiController;
	public GameObject preparationSteps;

	public void removeFirstMenu () {//called when the assessment button is pressed - gets rid of all buttons on screen and brings up the right arrow
		about.SetActive (false); 
		repair.SetActive (false);
		test.SetActive (false);
		next.SetActive (false);
		right.SetActive (true);
	}

	public void bringFirstMenu () {//called when any model is pressed and brings out the first menu
		about.SetActive (true); 
		repair.SetActive (true);
		test.SetActive (true);
		next.SetActive (false);
		left.SetActive (false);
		right.SetActive (false);
		showAnswers (7, false);
		question.SetActive (false);
		up.SetActive (false);
		down.SetActive (false);
		ITtext.SetActive (true);
		interactAnswers (true);
	}

	public void testButtons () { // called when the assessment button is pressed and sets up the buttons for testing
		about.SetActive (false);
		repair.SetActive (false);
		test.SetActive (false);
		left.SetActive (false);
		right.SetActive (false);
		next.SetActive (true);
		showAnswers (4, true);
		question.SetActive (true);
		ITtext.SetActive (false);
	}

	public void optionsMenuOn (bool b) { //toggles the options menu
		optionsPanel.SetActive (b);
		menuOccluder.SetActive(b);
		if (preparationSteps.activeInHierarchy == true) {
			uiController.screwOn();
		}
	}

	public void showAnswers (int w, bool b) { //toggles the answers, which appear between questions
		for (int i = 0; i < w; i++) {
			answer [i].SetActive (b);
		}
	}

	public void interactAnswers(bool b){ //toggles ability to touch answers in ordering section one submit is pressed
		for (int i = 0; i < 7; i++) {
			answer [i].GetComponent<Button>().interactable = b;
		}
	}

	public void userGuideOn (bool b) { //toggles the user guide
		userGuidePanel.SetActive (b);
	}

	public void nextOn (bool b) { //toggles the next button, which appears after an answer is submitted in order to go the the next question
		next.SetActive (b);
	}

	public void LeftOn (bool b) {//toggles the left arrow button, which will appear as long as there is a panel to the left
		left.SetActive (b);
	}

	public void rightOn (bool b) {//toggles right left arrow button, which will appear as long as there is a panel to the right
		right.SetActive (b);
	}
	public void downOn (bool b) {//toggles down arrow button, which will appear whenever selected tect box is not at the bottom.
		down.SetActive (b);
	}
	public void upOn (bool b) {//toggles up arrow button, which will appear whenever selected tect box is not at the top.
		up.SetActive (b);
	}


	}


