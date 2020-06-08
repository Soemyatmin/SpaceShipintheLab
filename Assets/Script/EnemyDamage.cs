using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public float Damage;

	public bool isObstacle = false;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player" ) {
			if (Damage >= other.GetComponent<Health> ().hitPoint) {
				Destroy (other.gameObject);
			} else {
				other.GetComponent<Health> ().hitPoint -= Damage;
			}
			if (!isObstacle) {
				Destroy (gameObject);
			}
		}
	}
}
