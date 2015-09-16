using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {
	public float TimeScale;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = TimeScale;
		if(GameMenuController.instance.isOver){
			TimeScale = 0.4f;
		}else{
			TimeScale = 1f;
		}
	}
}
