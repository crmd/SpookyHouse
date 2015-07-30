using UnityEngine;
using System.Collections;

public class EventToggleDoor : Event {

	private bool open = false;
	private Animator anim;

	// Use this for initialization
	public override void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public override void Update () {
	
	}
	public override void Activate()
	{
		base.Activate();
		if(open)
		{
			anim.SetBool("Open", false);
			open = false;
		}
		else
		{
			anim.SetBool("Open", true);
			open = true;
		}
	}
}
