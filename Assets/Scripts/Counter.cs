using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
	public int waitTime;
	// Use this for initialization
	void Start ()
	{
		waitTime = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
		waitTime -= 1;

		if (waitTime <= 0){
			Application.LoadLevel (Application.loadedLevel + 1);
		}

		if (Input.anyKey) {
			waitTime = -1;
		}
	}
}

