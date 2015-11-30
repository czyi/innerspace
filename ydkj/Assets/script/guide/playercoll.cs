using UnityEngine;
using System.Collections;

public class playercoll : MonoBehaviour {

	void OnTriggerEnter(Collider otherobject)
	{
		otherobject.GetComponent<pushubox_gravity> ().freemovepush (transform.position.x, transform.position.y,
		                                                            transform.position.z);

	}
}
