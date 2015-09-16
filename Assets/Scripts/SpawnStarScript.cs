using UnityEngine;
using System.Collections;

public class SpawnStarScript : MonoBehaviour {
	public GameObject star;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnStar());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnStar(){
		yield return new WaitForSeconds(0.01f);
		Instantiate(star,new Vector3(Random.Range(-10f,10f),6f,20f),Quaternion.identity);
		StartCoroutine(SpawnStar());
	}
}
