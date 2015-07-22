using UnityEngine;
using System.Collections;

// Player interacts with an object
public class TriggerInteraction : Trigger {

	public bool destroyOnUse = false;
//	public bool oneTimeUse = false;
//	private bool activated = false;
	private Transform player;
	public float interactDistance = 3.0f;

	public override void Start()
	{
		base.Start ();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	public void HighLightOn()
	{
		//Highlights the object when moused over
	}
	public void HighLightOff()
	{
		//Highlights the object when moused over
	}

	public override void Update()
	{
		base.Update ();

	}

	public void OnMouseEnter()
	{
		if (oneTimeUse && activated)
		{
			HighLightOn ();
		}
	}

	public void OnMouseExit()
	{
		HighLightOff ();
	}

	public void OnMouseOver()
	{
		if (Input.GetKeyDown (KeyCode.E)
		    && Vector3.Distance(transform.position, player.position) < interactDistance)
		{
			Activate();
		}
	}

	public void Activate()
	{
		if(requiresPower && !powered)
		{
			return;
		}
		if(oneTimeUse && activated)
		{
			return;
		}
		TriggerEvents ();
		activated = true;
		if(destroyOnUse)
		{
			Destroy(gameObject);
		}
	}
}
