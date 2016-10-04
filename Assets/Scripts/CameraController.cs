using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is also called once per frame, but it's called after all items
	// in the frame are processed. This guarantees the camera will move after 
	// the player object has moved  
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
