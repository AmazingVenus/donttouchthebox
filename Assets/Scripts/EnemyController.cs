using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	public float LifeTime;
	public GameObject splash;
	private AudioSource source;
	public AudioClip[] ExplodeSound;
	void Start () {
		splash = GameObject.Find ("BulletEffect");
		source = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.SetActive(!GameMenuController.instance.isOver);

		transform.position += Vector3.down * Time.deltaTime * speed;
		
		if(LifeTime <= 0){
			Destroy(this.gameObject);
		}
		LifeTime -= Time.deltaTime;
	}

	void OnTriggerEnter(Collider collider){
		//Debug.Log (collider.name);

		int n = (int)Random.Range(0f,ExplodeSound.Length);
		if(collider.tag == "Player"){
			source.PlayOneShot(ExplodeSound[n]);
			GameMenuController.instance.isOver = true;
			UpdateHighScore();
			ScoreController.instance.setScore(0);


		}else if (collider.tag == "Bullet" && !GameMenuController.instance.isOver){
			PlayerDataController.instance.AddPlayerCoin();
			ScoreController.instance.AddScore();
			source.PlayOneShot(ExplodeSound[n]);
		}

		this.GetComponent<BoxCollider>().enabled = false;
		this.GetComponent<Renderer>().enabled = false;

		splash.transform.position = this.transform.position;
		splash.GetComponent<ParticleSystem>().Play();

		Destroy(this.gameObject,ExplodeSound[n].length);
	}

	void UpdateHighScore(){
		int score = ScoreController.instance.score ;
		if(score >= PlayerPrefs.GetInt("HIGH_SCORE",0)){
			PlayerPrefs.SetInt("HIGH_SCORE",score);
		}
	}

}
