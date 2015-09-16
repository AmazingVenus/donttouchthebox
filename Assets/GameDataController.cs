using UnityEngine;
using System.Collections;

public class GameDataController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnApplicationQuit() {
		PlayerPrefs.Save();
		Debug.Log("Data Saved");
	}
}
