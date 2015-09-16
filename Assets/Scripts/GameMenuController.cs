using UnityEngine;
using System.Collections;

public class GameMenuController : MonoBehaviour {
	public static GameMenuController instance;

	public bool isBegin;
	public bool isOver;
	public bool isUpgrade;

	public GameObject GameoverMenuObject;
	public GameObject StartMenuObject;
	public GameObject UpgradeMenuObject;
	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameoverMenuObject.SetActive(isOver && !isUpgrade);
		StartMenuObject.SetActive(!isBegin && !isUpgrade);
		UpgradeMenuObject.SetActive(isUpgrade);

		if(Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();
		}
	}

	public void setBegin(bool value){
		isBegin = value;
	}
	public void setOver(bool value){
		isOver = value;
	}
	public void setUpgrade(bool value){
		isUpgrade = value;
	}
	public void ClearObject(string tag){
		Destroy(GameObject.FindGameObjectWithTag(tag));
	}
}
