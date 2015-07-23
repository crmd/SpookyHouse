using UnityEngine;
using System.Collections;

// Object moves between two points
public class EventMove : Event {

	public float closeEnoughDistance = 0.01f;
	public float moveSpeed = 1.0f;
	private bool moving;
	public Vector3 endPoint;
	public bool disableOnStop = true;

	public override void Start () {
		base.Start ();
	}
	
	public override void Update () {
		base.Update ();
		if (moving) {
			if(Vector3.Distance(transform.position, endPoint) <= closeEnoughDistance)
			{
				moving = false;
				if(disableOnStop)
				{
					gameObject.SetActive(false);
				}
			}
			transform.position = Vector3.MoveTowards(transform.position, endPoint, moveSpeed * Time.deltaTime);
		}
	}

	public override void Activate()
	{
		base.Activate ();
		moving = true;
	}
}
