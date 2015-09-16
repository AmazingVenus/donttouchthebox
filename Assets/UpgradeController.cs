using UnityEngine;
using System.Collections;
using System;

public class UpgradeController : MonoBehaviour {
	public static UpgradeController instance;

	public int FireRateCost;
	public float FireRateLevel;
	public float FireRateAdd;

	void Awake(){
		instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		FireRateLevel = PlayerDataController.instance.PLAYER_FIRERATE_LVL;
		FireRateCost = (int)Math.Ceiling((1.5f * Math.Pow(1.7f,(FireRateLevel+1)*0.5)));
		FireRateAdd = (float)(0.4f * Math.Pow(1.5f,1/(FireRateLevel+1)*0.5));
	}

	public void DoUpdateFireRate(){
		if(CheckPlayerCoin()){
			FireRateLevel++;
			PlayerDataController.instance.AddPlayerFireRate(FireRateAdd);
			PlayerDataController.instance.AddPlayerFireRateLvl();
			PlayerDataController.instance.MinusPlayerCoin(FireRateCost);
		}
	}

	private bool CheckPlayerCoin(){
		if(PlayerDataController.instance.PLAYER_COIN < FireRateCost){
			return false;
		}else{
			return true;
		}
	}
}
