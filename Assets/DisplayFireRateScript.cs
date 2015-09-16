using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayFireRateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = "Your FireRate : "+PlayerDataController.instance.PLAYER_FIRERATE.ToString("#.##")+"/s";
	}
}
