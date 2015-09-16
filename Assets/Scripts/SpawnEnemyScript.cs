using UnityEngine;
using System.Collections;

public class SpawnEnemyScript : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds(0.12f);
		if(GameMenuController.instance.isBegin && !GameMenuController.instance.isOver){
			Instantiate(enemy,new Vector3(Random.Range(-5f,5f),6f,5f),Quaternion.identity);
		}
		StartCoroutine(SpawnEnemy());
	}
}
