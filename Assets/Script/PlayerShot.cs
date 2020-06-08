using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

	public GameObject bullet1;
	public GameObject bullet2;
	public float Bulletinterval;

	public GameObject laser;
	public float Laserinterval;

	[Space(10)]
	public GameObject BiggerBullet;
	public GameObject Shield;
	public float CoolDown;

	[Space(10)]
	public int ShotterType0 = 0;
	public int ShotterType1 = 0;

	public Transform bulletSpawn;
	float temp0 = 0 ,temp1 = 0;

	public float backToNormalInterval = 10;
	public float backToNormalTemp;
	void Update () {
		if (Input.GetMouseButton (0) && Time.time> temp0) {
			if (ShotterType0 == 1) {
				Instantiate (bullet2, bulletSpawn.position, Quaternion.identity);
				temp0 = Time.time + Bulletinterval;
			} else if (ShotterType0 == 2) {
				Instantiate (laser, bulletSpawn.position, Quaternion.identity);
				temp0 = Time.time + Laserinterval;
			} else {
				Instantiate (bullet1, bulletSpawn.position, Quaternion.identity);
				temp0 = Time.time + Bulletinterval;
			}
		}

		if (Input.GetMouseButton (1) && Time.time > temp1) {
			if (ShotterType1 == 1) {
				GameObject g = Instantiate (Shield, bulletSpawn.position, Quaternion.identity) as GameObject;
				g.GetComponent<CoverMovement> ().addedInterval = 0;
				g = Instantiate (Shield, bulletSpawn.position, Quaternion.identity) as GameObject;
				g.GetComponent<CoverMovement> ().addedInterval = 3.14f;

			} else {
				Instantiate (BiggerBullet, bulletSpawn.position, Quaternion.identity);
			}
			temp1 = Time.time + CoolDown;
		}

		if (backToNormalTemp < Time.time) {
			ShotterType0 = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "item_Tri") {
			ShotterType0 = 1;
			Destroy (other.gameObject);
			backToNormalTemp = Time.time + backToNormalInterval;
		}
		if (other.tag == "item_Laser") {
			ShotterType0 = 2;
			Destroy (other.gameObject);
			backToNormalTemp = Time.time + backToNormalInterval;
		}
		if (other.tag == "item_BiggerBullet") {
			ShotterType1 = 0;
			Destroy (other.gameObject);
		}
		if (other.tag == "item_Shield") {
			ShotterType1 = 1;
			Destroy (other.gameObject);
		}
	}

	public void rightClick(){
		if (Time.time > temp1) {
			if (ShotterType1 == 1) {
				GameObject g = Instantiate (Shield, bulletSpawn.position, Quaternion.identity) as GameObject;
				g.GetComponent<CoverMovement> ().addedInterval = 0;
				g = Instantiate (Shield, bulletSpawn.position, Quaternion.identity) as GameObject;
				g.GetComponent<CoverMovement> ().addedInterval = 3.14f;

			} else {
				Instantiate (BiggerBullet, bulletSpawn.position, Quaternion.identity);
			}
			temp1 = Time.time + CoolDown;
		}
	}
}
