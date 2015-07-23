using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EventEnableObject : Event {
	public List<GameObject> objectsToEnable;
	// Use this for initialization
	public override void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
	
	}

	public override void Activate()
	{
		for(int i = 0; i < objectsToEnable.Count; ++i)
		{
			objectsToEnable[i].SetActive(true);
		}
	}
}
