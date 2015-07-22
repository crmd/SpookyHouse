using UnityEngine;
using System.Collections;

public class TriggerTimer : Trigger {

	public float activateTime = 5.0f;
	private float curTimer;
	public float timerVariance = 0.0f;

	public override void Start () {
		curTimer = activateTime;	
	}
	
	public override void Update () {
		curTimer -= Time.deltaTime;
		if(curTimer <= 0)
		{
			curTimer = activateTime + Random.Range(-timerVariance/2, timerVariance/2);
			TriggerEvents();
		}
	}
}
