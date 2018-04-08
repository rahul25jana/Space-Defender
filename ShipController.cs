using UnityEngine;
using System.Collections;

public class Control_Player : MonoBehaviour {

	public float speed = 30.0f;
	
	float min_x = -5f;
	float max_x = 5f;
	public float pad = 1f;
	
	// Use this for initialization
	void Start () 
	{
	
	float Z_distance = transform.position.z - Camera.main.transform.position.z;
	Vector3 left_most = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Z_distance )); // takes in world point and returns the world point coordinate // should find the distance
	Vector3 right_most = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, Z_distance )); // takes in world point and returns the world point coordinate
	//Vector3 upper_most = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Z_distance ));
//	Vector3 down_most = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Z_distance ));
		
		min_x  = left_most.x +  pad;
		max_x = right_most.x -  2 * pad;                                                  
		
	}
	
	// Update is called once per frame
	void Update () 
	
	{
//		Vector3 ShipPos = new Vector3(0.0f, this.transform.position.y, 2.5f );
//		float mos_pos = Input.mousePosition.x / Screen.width * 2;
//		ShipPos.x = Mathf.Clamp(mos_pos, 0.5f, 10.0f);
//		this.transform.position = ShipPos;
//		
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 ShipPos = this.transform.position;
			ShipPos.x += -speed * Time.deltaTime;
			this.transform.position = ShipPos;
		}
		
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 ShipPos = this.transform.position;
			ShipPos.x += speed * Time.deltaTime;
			this.transform.position = ShipPos;
		}
		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 ShipPos = this.transform.position;
			ShipPos.y += speed * Time.deltaTime;
			this.transform.position = ShipPos;
		}
		
		if (Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 ShipPos = this.transform.position; 
			ShipPos.y += -speed * Time.deltaTime;
			this.transform.position = ShipPos;
		}
		
		// will restrict the player in game space
		float X_new = Mathf.Clamp(transform.position.x, min_x, max_x);
		transform.position = new Vector3(X_new, transform.position.y, transform.position.z); // will reset the transform
		//float X_news = Mathf.Clamp(transform.position.y, min_x, max_x);  // extra --> moving y axis
		//transform.position = new Vector3(transform.position.x, X_news, transform.position.z); 
		
	}
	
	
	
}
