using UnityEngine;
using System.Collections;

public class ColorCycle : MonoBehaviour
{
	//this class exists for the express purpose of changing the color of the components through a rainbow once all tests have been completed.
	public int stage = 0;
	public float r; //red variable
	public float g; //green variable
	public float b; //blue varible
	public Renderer[] PhazerBeam;
	// Use this for initialization
	void Start ()
	{
		foreach (Renderer thing in PhazerBeam) {
			thing.material.EnableKeyword ("_EmissionColor");
			thing.material.color = Color.red;
			thing.material.SetColor ("_EmissionColor", Color.red);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		switch (stage) {
		case 0:
			g += 0.03f;
			if (g >= 1.0f) {
				g = 1.0f;
				stage++;
			}
			break;
		case 1:
			r -= 0.03f;
			if (r <= 0.0f) {
				r = 0.0f;
				stage++;
			}
			break;
		case 2:
			b += 0.03f;
			if (b >= 1.0f) {
				b = 1.0f;
				stage++;
			}
			break;
		case 3:
			g -= 0.03f;
			if (g <= 0.0f) {
				g = 0.0f;
				stage++;
			}
			break;
		case 4:
			r += 0.03f;
			if (r >= 1.0f) {
				r = 1.0f;
				stage++;
			}
			break;
		case 5:
			b -= 0.03f;
			if (b <= 0.0f) {
				b = 0.0f;
				stage = 0;
			}
			break;
		}
		foreach (Renderer thing in PhazerBeam) {
			thing.material.color = new Color (r, g, b);
			thing.material.SetColor ("_EmissionColor", new Color (r, g, b));
		}
	}
}

