using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	private int score;
	public Text scoreText;
	public Text winText;

	void Start () {
		rb = GetComponent<Rigidbody>();
		score = 0;
		SetScoreText ();
		winText.text = "";
	}

	// Update is called before every frame
	void Update () {
	
	}

	// FixedUpdate is called before physics calculation
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// 0.0f casts it as float, 0.0 casts it as double, 0 is integer
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
		
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		// If the collider object is tagged "Pick Up", deactivate it
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			score++;
			SetScoreText (); // Update UI score text
		}
	}

	void SetScoreText() {
		scoreText.text = "Score: " + score.ToString ();

		if (score >= 7) {
			winText.text = "You Win!";
		}
	}
}
