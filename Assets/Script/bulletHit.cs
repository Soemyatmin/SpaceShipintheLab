using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour {

	public float Damage = 3.0f;
	public bool notDestory = false;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy" || other.tag == "EnemyBullet") {
			if (Damage >= other.GetComponent<Health> ().hitPoint) {
				other.GetComponent<Health> ().dead ();
			} else {
				other.GetComponent<Health> ().hitPoint -= Damage;
			}
		} 
		if (other.tag != "Player" && other.tag != "PlayerBullet" && !notDestory) {
			Destroy (gameObject);
		}


	}
}
