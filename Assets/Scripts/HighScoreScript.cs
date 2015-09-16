using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "HIGH SCORE : "+PlayerPrefs.GetInt("HIGH_SCORE",0);
	}
}
