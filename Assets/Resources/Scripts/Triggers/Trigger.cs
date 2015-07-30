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
	public bool ignoreIfPowered = false;
	protected static bool hasKey = false;
	public bool requiresKey = false;

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

	public void GetKey()
	{
		hasKey = true;
	}

	public virtual void TriggerEvents()
	{
		if(oneTimeUse && activated)
		{
			return;
		}
		if(ignoreIfPowered && powered)
		{
			return;
		}
		if(requiresKey && !hasKey)
		{
			return;
		}
		activated = true;
		for(int i = 0; i < linkedEvents.Count; ++i)
		{
			if(linkedEvents[i])
			{
				linkedEvents[i].Activate();
			}
		}
	}
}
