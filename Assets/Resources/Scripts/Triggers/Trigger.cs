using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Trigger : MonoBehaviour {

	public List<Event> linkedEvents = new List<Event>();
	public bool requiresPower = false;
	protected static bool powered = true;

	
	public bool oneTimeUse = false;
	protected bool activated = false;

//	public Trigger (){}

	public virtual void Start()
	{

	}

	public virtual void Update()
	{

	}

	public void PowerOn()
	{
		powered = true;
	}

	public void PowerOff()
	{
		powered = false;
	}

	public virtual void TriggerEvents()
	{
		if(oneTimeUse && activated)
		{
			return;
		}
		activated = true;
		for(int i = 0; i < linkedEvents.Count; ++i)
		{
			linkedEvents[i].Activate();
		}
	}
}
