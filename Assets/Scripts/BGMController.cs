using UnityEngine;
using System.Collections;

public class BGMController : MonoBehaviour {
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameMenuController.instance.isOver){
			source.volume = 0.4f;
		}else{
			source.volume = 0.8f;
		}
	}
}
