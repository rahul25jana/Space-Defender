 using UnityEngine;
using System.Collections;

public class bullet_behaviour : MonoBehaviour {

public float damage_ratio = 100f;

public float Get_Damage()

{
return damage_ratio;

}
public void Hit()

{
Destroy(gameObject);

}
}
