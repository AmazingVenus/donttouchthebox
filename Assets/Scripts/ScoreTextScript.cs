using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = ScoreController.instance.GetScore().ToString();
	}
}
