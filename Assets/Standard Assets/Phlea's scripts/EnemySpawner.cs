using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

	void Start () {
		Scene season = SceneManager.GetActiveScene ();
		switch(season) {
		case "fall":
			break;
		case "spring":
			break;
		case "summer":
			break;
		case "winter":
			break;
		case "boss":
			break;
		}
	}
	
	void Update () {
		
	}
}
