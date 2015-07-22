using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Used on light switches, toggles lights
public class EventToggleLights : Event {

	public bool lightsOn = false;
	public List<Light> connectedLights = new List<Light>();

	public override void Start () {
		base.Start ();
	}
	
	public override void Update () {
		base.Update ();
		if (powerOn) {
			if (lightsOn)
			{
				SetLights(true);
			}
			else
			{
				SetLights(false);
			}
		}
		else
		{
			SetLights(false);
		}
	}

	private void SetLights(bool val)
	{
		for(int i = 0; i < connectedLights.Count; ++i)
		{
			connectedLights[i].enabled = val;
		}
	}

	public override void Activate()
	{
		base.Activate ();
		if (lightsOn)
		{
			lightsOn = false;
		}
		else
		{
			lightsOn = true;
		}
	}
}
