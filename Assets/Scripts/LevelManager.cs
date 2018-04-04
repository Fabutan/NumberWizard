using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {



	public void LoadLevel(string name) {
		Debug.Log ("Load Level Requested: " + name);
		SceneManager.LoadScene (name);
	}

	public void Quit() {
		Debug.Log ("Quit Function");
		Application.Quit ();
	}
}
