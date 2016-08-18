﻿using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
	public int waitTime;
	// Use this for initialization
	void Start ()
	{
		waitTime = 200;
	}
	
	// Update is called once per frame
	void Update ()
	{


		//get touch input
		Touch myTouch;

		//Touch[] myTouches = Input.touches;

		for (int i = 0; i < Input.touchCount; i++) {
			myTouch = Input.GetTouch (i);
			if (myTouch.phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay (myTouch.position);
				RaycastHit hit;
				Physics.Raycast (ray, out hit);

				if (hit.rigidbody.gameObject.name == "SkipFrame") {
					waitTime = -1;

				}
			}
		}

		waitTime -= 1;

		if (waitTime <= 0){
			Application.LoadLevel (Application.loadedLevel + 1);
		}

		if (Input.anyKey) {
			waitTime = -1;
		}
	}
}

