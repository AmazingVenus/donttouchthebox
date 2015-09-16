using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = PlayerDataController.instance.PLAYER_COIN.ToString();
	}
}
