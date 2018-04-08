using UnityEngine;
using System.Collections;

public class Spawn_Enemy : MonoBehaviour {

public GameObject enemy_prefab;

	// Use this for initialization
	void Start () {
	

	
	foreach(Transform child in transform )
	
	{
			GameObject enemy = Instantiate(enemy_prefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
	}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
