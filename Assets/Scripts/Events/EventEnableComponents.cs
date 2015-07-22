using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Enables components on the object
public class EventEnableComponents : Event {

	public List<MonoBehaviour> components = new List<MonoBehaviour>();

	public override void Start () {
		base.Start ();
	}
	
	public override void Update () {
		base.Update ();
	}
	
	public override void Activate()
	{
		base.Activate ();
		for(int i = 0; i < components.Count; ++i)
		{
			components[i].enabled = true;
		}
	}
}
