using UnityEngine;
using System.Collections;

// Object moves between two points
public class EventMove : Event {

	public float closeEnoughDistance = 0.01f;
	public float duration = 2.0f;
	private bool moving;
	public Transform endPoint;
	public bool disableOnStop = true;
	private float dist; 
	public bool activateOnStart = true;
	public override void Start () {
		base.Start ();
		dist = Vector3.Distance (transform.position, endPoint.position);
		if(activateOnStart)
		{
			Activate();
		}
	}
	
	public override void Update () {
		base.Update ();
		if (moving) {
			if(Vector3.Distance(transform.position, endPoint.position) <= closeEnoughDistance)
			{
				moving = false;
				if(disableOnStop)
				{
					gameObject.SetActive(false);
				}
			}
			transform.position = Vector3.MoveTowards(transform.position, endPoint.position, dist/duration * Time.deltaTime);
		}
	}

	public override void Activate()
	{
		base.Activate ();
		moving = true;
	}
}
