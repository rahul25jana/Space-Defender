using UnityEngine;
using System.Collections;

public class Control_Player : MonoBehaviour {

	public float speed = 15.0f;
	
	// Use this for initialization
	void Start () 
	{
	
		
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
		
		
	}
	
}
