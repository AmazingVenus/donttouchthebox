using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
	public static ScoreController instance;
	public int score;
	void Awake (){
		instance = this;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore() {
		score += 1;
	}

	public void MinusScore() {
		score -= 1;
	}
	public void setScore(int value){
		score = value;
	}
	public int GetScore() {
		return score;
	}
}
