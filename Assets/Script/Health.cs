using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour {

	public float hitPoint = 20.0f;

	public bool ExplotedEnemy = false;
	public GameObject explotedBullet;


	public void dead(){
		if(ExplotedEnemy){
			Instantiate (explotedBullet, transform.position, Quaternion.identity);
		}
		Destroy (gameObject);
	}
}
