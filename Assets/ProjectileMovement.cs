using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

	public GameController pointCounter;

	// Use this for initialization
	void Start () {
		pointCounter = FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 4);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			//do nothing
		}
		if (col.tag == "Enemy") {
			Destroy (gameObject);
			pointCounter.score++;
		}
	}
}
