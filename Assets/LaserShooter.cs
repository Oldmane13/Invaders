using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooter : MonoBehaviour {

	public GameObject projectile;
	public Transform shootsyArea;
	public float timeBetweenShots = 0.25f;

	private float timestamp;

	void Update () {
		
		if (Time.time >= timestamp && (Input.GetMouseButtonDown (0)) ) {
			Instantiate (projectile, shootsyArea.position, shootsyArea.rotation);
			timestamp = Time.time + timeBetweenShots;
		}
	}
}