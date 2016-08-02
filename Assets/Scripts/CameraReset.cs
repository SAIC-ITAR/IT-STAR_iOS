using UnityEngine;
using System.Collections;

public class CameraReset : MonoBehaviour {

	public Vector3 position1 = new Vector3 (0, 0, 0);
	public Vector3 position2 = new Vector3 (1, 1, 1);
	public GameObject ARCamera;
	public bool trackingLost;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (trackingLost == false) {
			Debug.Log ("tracking object lost!");
		}




	}


	void LateUpdate(){
		//Debug.Log (position1);
		///Debug.Log (position2);

		position2 = position1;
	
	}

}
