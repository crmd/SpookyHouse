using UnityEngine;
using System.Collections;

public class EventGetKey : Event {

	private Trigger trigger;

	// Use this for initialization
	public override void Start () {
		trigger = GetComponent<Trigger>();
	}

	public override void Activate()
	{
		base.Activate();
		trigger.GetKey();
	}
}
