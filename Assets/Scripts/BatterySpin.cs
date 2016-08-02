using UnityEngine;
using System.Collections;

public class BatterySpin : MonoBehaviour {
	public int speed;

	public int direction = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left, speed * Time.deltaTime, Space.World);	

	}
}
