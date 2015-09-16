using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	public float LifeTime;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.up * Time.deltaTime * speed;

		if(LifeTime <= 0){
			Destroy(this.gameObject);
		}
		LifeTime -= Time.deltaTime;
	}

	void OnTriggerEnter(){
		Destroy(this.gameObject);
	}
}
