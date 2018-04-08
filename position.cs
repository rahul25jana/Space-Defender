using UnityEngine;
using System.Collections;

public class Positions : MonoBehaviour {


void onDrawGizmos()

{

Gizmos.DrawWireSphere(transform.position, 1);

}


}
