using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwitchController : MonoBehaviour {

	public GameObject Sun;
	public bool LightStatus = true;
	public GameObject Switch;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Sun.GetComponent<Light>().enabled = Switch.GetComponentInChildren<Toggle>().isOn;
	}

	void OnGUI(){
		if (LightStatus) {
			if (GUI.Button (new Rect (Screen.width / 2 - 50f, Screen.height / 2 - 50f, 100f, 100f), "Turn Off")) {
			
				//Sun.GetComponent<Light>().enabled = !Sun.GetComponent<Light>().enabled;	
				Sun.GetComponent<Light>().enabled = false;
				LightStatus = false;
				Debug.Log ("Hello World");
			}
		}
		else {
			if(GUI.Button (new Rect (Screen.width/2 - 50f, Screen.height/2 - 50f, 100f, 100f), "Turn On")) {
			
				//Sun.GetComponent<Light>().enabled = !Sun.GetComponent<Light>().enabled;	
				Sun.GetComponent<Light>().enabled = true;
				LightStatus = true;
				Debug.Log("Hello World");
			}
		}

	}
}
