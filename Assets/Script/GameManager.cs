using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Player;

	public float minX,maxX,Y;

	public float enP,itP, obP;
	public GameObject[] Enemies;
	public GameObject[] Items;
	public GameObject[] Obstacles;

	public float interval = 1;

	public GameObject deadCanvas;
	// Use this for initialization
	IEnumerator Start () {
		deadCanvas.SetActive(false);
		while (Player) {
			int percentage = Random.Range (0, 100);
			if (percentage < enP) {
				Instantiate (Enemies [Random.Range (0, Enemies.Length)],
					new Vector2 (Random.Range (minX, maxX), Y),
					Quaternion.identity);
			} else if (percentage > enP && percentage < (enP + itP)) {
				Instantiate (Items [Random.Range (0, Items.Length)],
					new Vector2 (Random.Range (minX, maxX), Y),
					Quaternion.identity);
			} else if (percentage > (enP + itP)) {
				Instantiate (Obstacles [Random.Range (0, Obstacles.Length)],
					new Vector2 (Random.Range (minX, maxX), Y),
					Quaternion.identity);
			}

			yield return new WaitForSeconds (interval);
		}
		deadCanvas.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
}
