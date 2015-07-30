using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventEnableAudio : Event {

	public List<AudioSource> audioSources;

	// Use this for initialization
	public override void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
	
	}

	public override void Activate()
	{
		base.Activate();
		for(int i = 0; i < audioSources.Count; ++i)
		{
			audioSources[i].enabled = true;
		}
	}
}
