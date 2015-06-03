using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {
	public Rigidbody rb;
	public float jumpHeight = 0;
	private bool canJump = true;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2") && canJump == true) {

			rb.AddForce (transform.up * jumpHeight);

			canJump = false;
		}
	}

	void OnCollisionEnter()
	{
		canJump = true;
	}
}
