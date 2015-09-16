using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.SetActive(!GameMenuController.instance.isBegin);
		if(Input.GetKeyDown(KeyCode.Space)){ //if(Input.GetMouseButtonUp(0)){
			GameMenuController.instance.isBegin = true;
		}
	}
}
