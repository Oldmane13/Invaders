using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float speed;
	public float direction;

	public float verticalSpeed;
//	public float horizontalSpeed;
//	public float amplitude;

	public float time;

	Vector3 tempPosition;
	Transform trans;

	void Start(){

		//direction = Random.Range (-2, 2);

		trans = GetComponent<Transform>();

		tempPosition = trans.position;
	}

	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, speed);
		tempPosition.y -= verticalSpeed;
//		tempPosition.x = Mathf.Sin (Time.realtimeSinceStartup * horizontalSpeed) * amplitude;
//		transform.position = tempPosition;
		trans.position = new Vector3(tempPosition.x + Mathf.PingPong(Time.time, time), tempPosition.y , tempPosition.z);

	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "Bullet" || col.tag == "Border") {
			Destroy (gameObject);
		}
	}
}
