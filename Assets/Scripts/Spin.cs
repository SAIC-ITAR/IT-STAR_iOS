using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public int speed;

	public int direction = 0;
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("spin");

		transform.Rotate (Vector3.up, speed * Time.deltaTime, Space.World);	


		/*
		if (Input.GetKeyDown("q")){
			direction = 0;
		}
		if (Input.GetKeyDown("w")){
				direction = 1;
			}
		if (Input.GetKeyDown("e")){	
					direction = 2;
				}


		if (direction == 0) {
			transform.Rotate (Vector3.left, speed * Time.deltaTime);	
		}		if (direction == 0) {
			transform.Rotate (Vector3.left, speed * Time.deltaTime);	
		}
		else if (direction == 1) {
			transform.Rotate (Vector3.forward, speed * Time.deltaTime);	
		}
		else if (direction == 2) {
			transform.Rotate (Vector3.up, speed * Time.deltaTime);	
		}
		*/
	}
	/*public void stopspeed () {
		speed = 0;
	}
	public void speedup () {
		speed = 25;
	}
	*/
}
