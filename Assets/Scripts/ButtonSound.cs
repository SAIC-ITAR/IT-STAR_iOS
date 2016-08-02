using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Button))] //this means it needs to be attached with button 
public class ButtonSound : MonoBehaviour {

	public AudioClip sound;
	public AudioSource source {get {return GetComponent<AudioSource> (); }} 

	private Button buttons {get {return GetComponent<Button> (); }}


	// I could make multiple audiosources....... since i cnat turn it into an array 
	// Use this for initialization
	void Start () {

		gameObject.AddComponent <AudioSource> ();
		source.clip=sound;
		source.playOnAwake=false; 

		// okay this takes the audioclip named sound and makes it the audiosource that is what the clip part is doing 
		buttons.onClick.AddListener(()=>playSound());
	}


	// Update is called once per frame


	public void playSound(){
		source.Play ();
	}


}
