using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Player
	public float speed;
	public GameObject Bullets;
	public float fireRate;

	//Environment
	public GameObject BorderLeft;
	public GameObject BorderRight;
	public AudioClip[] ShootingSound;

	//Internal Component
	private AudioSource AS;
	private RaycastHit hit; 

	//Status
	private int MoveX;
	private float MoveY;
	private float fireTime;
	private float fireDelay;

	void Start () {
		AS = this.GetComponent<AudioSource>();
		//fireRate = PlayerDataController.instance.PLAYER_FIRERATE;

	}
	
	// Update is called once per frame
	void Update () {
		fireRate = PlayerDataController.instance.PLAYER_FIRERATE;
		fireDelay = 1f/fireRate;
		if(!GameMenuController.instance.isOver && GameMenuController.instance.isBegin){
			PlayerMovement ();
		}

		if(fireTime <= 0){
			PlayerShooting();
			fireTime = fireDelay;
		}
		fireTime -= Time.deltaTime;
	}

	void PlayerShooting(){
		if (/*Input.GetKeyDown(KeyCode.Space) && */!GameMenuController.instance.isOver && GameMenuController.instance.isBegin) {
			GameObject _temp = (GameObject)Instantiate(Bullets,this.transform.position,Quaternion.identity);
			Color32 color = new Color32((byte)Random.Range(200,255),(byte)Random.Range(200,255),(byte)Random.Range(200,255),(byte)Random.Range(0,255));
			_temp.GetComponent<Renderer>().material.color = color;
			_temp.GetComponent<TrailRenderer>().material.color = color;

			int n = (int)Random.Range(0f,ShootingSound.Length);
			AS.PlayOneShot(ShootingSound[n]);

		}
	}

	void PlayerMovement(){
		#region PlayerMovement
		//Vector3 ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		Vector3 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		ray.z = 5;
		transform.position = Vector3.Lerp (transform.position, ray, 20 * Time.deltaTime);

		//if(GameMenuController.instance.isBegin && !GameMenuController.instance.isOver){
			//MoveX = Input.GetAxisRaw ("Horizontal");
		//	transform.position += Vector3.right * MoveX * Time.deltaTime * speed;
		//}

		if(this.transform.position.x < BorderLeft.transform.position.x){
			Vector3 v = this.transform.position;
			v.x = BorderLeft.transform.position.x;
			this.transform.position = v;
		}

		if(this.transform.position.x > BorderRight.transform.position.x){
			Vector3 v = this.transform.position;
			v.x = BorderRight.transform.position.x;
			this.transform.position = v;
		}
		#endregion

	}
	
}
