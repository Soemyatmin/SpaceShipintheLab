using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScenes(string scenesName){
		SceneManager.LoadScene (scenesName);
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void Exit(){
		Application.Quit ();
	}
}
