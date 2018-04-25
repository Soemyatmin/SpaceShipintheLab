using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverMovement : MonoBehaviour {
	public float x, y;
	GameObject Player;

	public float DistanceSpeed= 1;
	public float CircularMovementSpeed =1 ;

	public float addedInterval;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (!Player) {
			Destroy (gameObject);
		} else {
			x = DistanceSpeed * Mathf.Sin (Time.time * CircularMovementSpeed + addedInterval) + Player.transform.position.x;
			y = DistanceSpeed * Mathf.Cos (Time.time * CircularMovementSpeed + addedInterval) + Player.transform.position.y;
			transform.position = new Vector2 (x, y);
		}
	}
}
