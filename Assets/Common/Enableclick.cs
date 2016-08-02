using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enableclick : MonoBehaviour {


	public Button about2;
	public Image imagine;
	//public Text words;
	//public GameObject text;

//	public Button tutorial;
//	public Button assessment;
//	public Button back; 
//	public Button left;
//	public Button right;

	void Start () {
		about2 =GetComponent<Button>();
		imagine=GetComponent<Image>();
		//words =GetComponent<Text>();
		//text = GameObject.Find("Text");

	}
	 void Update(){


		if(Input.GetKeyDown (KeyCode.Space)){
		about2.interactable=false;
			imagine.enabled = false;
	}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			about2.interactable = true;
			imagine.enabled = true;
		}
}
}
