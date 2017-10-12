using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject gremlin;

	public float waitingForNextSpawn;
	public float theCountdown;

	int spawn_num;
	public int score;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		theCountdown -= Time.deltaTime;

		if (theCountdown <= 0) {
			int spawn_num = Random.Range(0,7);

			Instantiate(gremlin, spawnPoints [spawn_num].position, spawnPoints [spawn_num].rotation);
			theCountdown = waitingForNextSpawn;

//			if (waitingForNextSpawn > 0.5f) {
//				waitingForNextSpawn -= 0.1f;
//			}
		}

		if (score == 5) {
			print ("yay");
			Time.timeScale = 0;
		}
	}
}
