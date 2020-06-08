using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByTime : MonoBehaviour {

	public float time =10;
	void Start () {
		Destroy(gameObject,time);
	}

}
