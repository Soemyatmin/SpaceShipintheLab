using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public float xMin, xMax, yMin, yMax;
	Rigidbody2D rigi2;
	// Use this for initialization
	void Start () {
		rigi2 = GetComponent<Rigidbody2D> ();
	}
	float h,v;
	// Update is called once per frame
	void Update () {
		
		#if UNITY_EDITOR
			h = Input.GetAxis ("Horizontal");
			v = Input.GetAxis ("Vertical");
		#elif UNITY_ANDROID
			h = Input.acceleration.x;//("Horizontal");
			v = Input.acceleration.y;// ("Vertical");
		#else
			h = Input.GetAxis ("Horizontal");
			v = Input.GetAxis ("Vertical");
		#endif

		if (transform.position.x < xMin) {
			h = Mathf.Clamp (h, 0, 1);
		} if (transform.position.x > xMax) {
			h = Mathf.Clamp (h, -1, 0);
		} if (transform.position.y < yMin) {
			v = Mathf.Clamp (v, 0, 1);
		} if (transform.position.y > yMax) {
			v = Mathf.Clamp (v, -1, 0);
		}

		rigi2.velocity = new Vector2 (h , v) * speed;
	}
}
