using UnityEngine;
using System.Collections;

public class Control_Player : MonoBehaviour {


	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	
	{
		Vector2 ShipPos = new Vector2( 0.0f, 1.0f );
		float mos_pos = Input.mousePosition.x / Screen.width;
		ShipPos.x = Mathf.Clamp(mos_pos, 0.5f, 15.5f);
		//this.transform.position = ShipPos;
		
		
	}
	
}
