using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventDestroyObject : Event {

	public List<GameObject> objectsToDestroy;

	public override void Activate()
	{
		for(int i = 0; i < objectsToDestroy.Count; ++i)
		{
			if(objectsToDestroy[i])
			{
				Destroy(objectsToDestroy[i]);
			}
		}
	}
}
