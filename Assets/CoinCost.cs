using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCost : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = UpgradeController.instance.FireRateCost.ToString();
	}
}
