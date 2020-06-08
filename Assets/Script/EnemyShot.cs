using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {
	public GameObject enemyBullet;
	public Transform bulletSpawn;
	public float interval;

	float temp;

	// Use this for initialization
	void Start () {
		temp = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.time > temp) {
				Instantiate (enemyBullet, bulletSpawn.position, Quaternion.identity);
				temp = Time.time + interval;

		}
	}
}
