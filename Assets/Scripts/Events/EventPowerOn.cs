using UnityEngine;
using System.Collections;

// Turns the power on for triggers
public class EventPowerOn : Event {
	private Trigger trigger;

	public override void Start()
	{
		base.Start ();
		trigger = GetComponent<Trigger> ();
	}
	public override void Activate()
	{
		base.Activate ();
		powerOn = true;
		trigger.PowerOn ();
	}
}
