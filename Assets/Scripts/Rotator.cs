using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Rotate in every frame and smooth the transform by making the it "frame
	// rate independent", i.e. transform an object 10 deg/second instead of
	// 10 deg/frame
	void Update () {
		transform.Rotate (new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
