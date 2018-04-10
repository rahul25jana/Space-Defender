using UnityEngine;
using System.Collections;

public class destroy_Bullets : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D colli)
	
	{
	
	Destroy(colli.gameObject);
	}
}
