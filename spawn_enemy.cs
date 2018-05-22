using UnityEngine;
using System.Collections;

public class Spawn_Enemy : MonoBehaviour {

public GameObject enemy_prefab;

public float W_width = 10f;
public float H_height = 8f;
public float Enemy_Speed = 8f;
public float spawnDelaySeconds = 1f;


private bool Right_move = true;
private float X_min;
private float X_max;

	

 
	
	// Use this for initialization
	void Start () {
	
		float ZZ_distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 left_edge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0 , ZZ_distance));
		Vector3 right_edge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0 , ZZ_distance));
		
		X_min = left_edge.x;
		X_max = right_edge.x;
		                                                     
		
		foreach(Transform child in transform )
	
	{
			GameObject enemy = Instantiate(enemy_prefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
	}
			SpawnEnemies();

	}
	
	public void onDrawGizmos()
	
	{

Gizmos.DrawWireCube(transform.position, new Vector3(W_width, H_height));
		
 		if(AllMembersAreDead()){
 			Debug.Log("My formation is empty :(");
 			SpawnUntilFull();
 		}
 	}
 
 	void SpawnEnemies(){
 		foreach( Transform position in transform){
 			GameObject enemy = Instantiate(enemyPrefab, position.transform.position, Quaternion.identity) as GameObject;
 			enemy.transform.parent = position;
 		}
 	}
 	
 	void SpawnUntilFull(){
 		Transform freePos = NextFreePosition();
 		GameObject enemy = Instantiate(enemyPrefab, freePos.position, Quaternion.identity) as GameObject;
 		enemy.transform.parent = freePos;
 		if(FreePositionExists()){
 			Invoke("SpawnUntilFull", spawnDelaySeconds);
 		}
 	}
 	
 	bool FreePositionExists(){
 		foreach(Transform position in transform){
 			if(position.childCount <= 0){
 				return true;
 			}
 		}
 		return false;
 	}
 	
 	Transform NextFreePosition(){
 		foreach(Transform position in transform){
 			if(position.childCount <= 0){
 				return position;
 			}
 		}
 		return null;
 	}
 
 	bool AllMembersAreDead(){
 		foreach(Transform position in transform){
 			if(position.childCount > 0){
 				return false;
 			}
 		}
 		return true;
  	}
  }
	}
	
	
	// Update is called once per frame
	void Update () 
	
	{
	
	if (Right_move)
	
	{
	transform.position +=  new Vector3(Enemy_Speed * Time.deltaTime, 0);
	}
	
	else {
			transform.position +=  new Vector3(-Enemy_Speed * Time.deltaTime, 0);
	
	}
	
	float right_edge_form = transform.position.x + (0.5f * W_width);
	float left_edge_form = transform.position.x + (0.5f * W_width);
	if ( left_edge_form < X_min )
	
	{
	Right_move =true;
	
		} else if (right_edge_form > X_max)
		
		{
			Right_move = false;
		}
	
	
	}
}
