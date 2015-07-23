using UnityEngine;
using System.Collections;

public class EventBlackout : Event {

	private Trigger trigger;

	public override void Start()
	{
		base.Start ();
		trigger = GetComponent<Trigger> ();
	}

	public override void Activate()
	{
		base.Activate ();
		powerOn = false;
		trigger.PowerOff ();
	}
}
