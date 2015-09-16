using UnityEngine;
using System.Collections;

public class PlayerDataController : MonoBehaviour {
	public static PlayerDataController instance;

	public string PLAYER_NAME;
	public float PLAYER_FIRERATE;
	public float PLAYER_FIRERATE_LVL;
	public int PLAYER_COIN;

	void Awake(){
		instance = this;
	}
	// Use this for initialization
	void Start () {
		PLAYER_NAME = PlayerPrefs.GetString("PLAYER_NAME","Amazing Box");
		PLAYER_FIRERATE = PlayerPrefs.GetFloat("PLAYER_FIRERATE",3f);
		PLAYER_FIRERATE_LVL = PlayerPrefs.GetInt("PLAYER_FIRERATE_LVL",1);
		PLAYER_COIN = PlayerPrefs.GetInt("PLAYER_COIN",0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddPlayerCoin(int among){
		int old_coin = PlayerPrefs.GetInt("PLAYER_COIN",0);
		PlayerPrefs.SetInt("PLAYER_COIN",old_coin+among);
		PLAYER_COIN = PlayerPrefs.GetInt("PLAYER_COIN",0);
	}

	public void MinusPlayerCoin(int among){
		int old_coin = PlayerPrefs.GetInt("PLAYER_COIN",0);
		PlayerPrefs.SetInt("PLAYER_COIN",old_coin-among);
		PLAYER_COIN = PlayerPrefs.GetInt("PLAYER_COIN",0);
	}

	public void AddPlayerCoin(){
		int old_coin = PlayerPrefs.GetInt("PLAYER_COIN",0);
		PlayerPrefs.SetInt("PLAYER_COIN",old_coin+1);
		PLAYER_COIN = PlayerPrefs.GetInt("PLAYER_COIN",0);
	}

	public void AddPlayerFireRate(float among){
		float old_value = PlayerPrefs.GetFloat("PLAYER_FIRERATE",3f);
		PlayerPrefs.SetFloat("PLAYER_FIRERATE",old_value+among);
		PLAYER_FIRERATE = PlayerPrefs.GetFloat("PLAYER_FIRERATE",3f);
	}
	public void AddPlayerFireRateLvl(){
		int old_value = PlayerPrefs.GetInt("PLAYER_FIRERATE_LVL",0);
		PlayerPrefs.SetInt("PLAYER_FIRERATE_LVL",old_value+1);
		PLAYER_FIRERATE_LVL = PlayerPrefs.GetInt("PLAYER_FIRERATE_LVL",0);
	}
}
