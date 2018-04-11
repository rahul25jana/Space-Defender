using UnityEngine;
using System.Collections;

public class Enemy_Behaviour : MonoBehaviour {

	// Use this for initialization
	
	public float health = 200;


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
}

}

}

}
