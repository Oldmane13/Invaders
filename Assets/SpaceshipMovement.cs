using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

	public float maxPos = 2.43f;
	public float shipSpeed;

	Vector3 position;
	Rigidbody2D rb;

	void Awake(){

		rb = GetComponent<Rigidbody2D> ();
	}

	void Start(){
		position = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		AccelerometerMove ();

		position = transform.position;
		position.x = Mathf.Clamp (position.x, -2.43f, 2.43f);
		transform.position = position;
	}

	void AccelerometerMove(){

		float x = Input.acceleration.x;
		Debug.Log ("X = " + x);


		if (x < -0.1f) {
			MoveLeft ();
		} else if (x > 0.1f) {
			MoveRight ();	
		} 
		else {
			SetVelocityZero();
		}

	}

	public void MoveLeft(){
		rb.velocity = new Vector2 (-shipSpeed, 0);
	}

	public void MoveRight(){

		rb.velocity = new Vector2 (shipSpeed, 0);
	}

	public void SetVelocityZero(){
		rb.velocity = Vector2.zero;
	}
}
