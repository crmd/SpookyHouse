using UnityEngine;
using System.Collections;

// Player enters an area
public class TriggerCollision : Trigger {

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Player")
		{
			TriggerEvents();
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			TriggerEvents();
		}
	}
}
