using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	Rigidbody2D rigi2;
	public float x, y;

	public bool Twisted = false;
	public float DistanceSpeed= 1;
	public float CircularMovementSpeed =1 ;


	// Use this for initialization
	void Start () {
		rigi2 = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Twisted) {
			x = DistanceSpeed * Mathf.Sin (Time.time * CircularMovementSpeed);
		}
		rigi2.velocity = new Vector2 (x, y);
	}
}
