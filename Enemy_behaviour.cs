using UnityEngine;
using System.Collections;

public class Enemy_Behaviour : MonoBehaviour {

	// Use this for initialization
	
	public float health = 200;
	public GameObject projectile;
	public float projectileSpeed = 10f;
	public float health = 150f;
	public float shotsPerSecond = 0.5f;
	public int scoreValue = 150;
  	
 	private ScoreKeeper scoreKeeper;
 	
 	void Start(){
 		scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
 	}
	void Update(){
 		float prob = shotsPerSecond * Time.deltaTime;
 		if(Random.value < prob){
 			Fire ();
 		}
 	}
 	
 	void Fire(){
 		Vector3 offset = new Vector3(0, -1.0f, 0);
 		Vector3 firePos = transform.position + offset;
 		GameObject laser = Instantiate(projectile, firePos, Quaternion.identity) as GameObject;
 		laser.rigidbody2D.velocity = new Vector2(0,-projectileSpeed);
 	}
 	

void OnTriggerEnter2D(Collider2D colld)

{

Debug.Log(colld);
bullet_behaviour gun = colld.gameObject.GetComponent<bullet_behaviour>();

if(gun)

{

health -= gun.Get_Damage();
gun.Hit();
if (health <=0)
{
Destroy(gameObject);
scoreKeeper.Score(scoreValue);

}

}

}

}
