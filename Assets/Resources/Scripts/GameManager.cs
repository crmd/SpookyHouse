using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool indoors;
	public AudioLowPassFilter lowPassFilter;

	public float indoorCutOff = 3500f;
	public float outdoorCutOff = 5000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void FixedUpdate()
	{
		if(indoors)
		{
			lowPassFilter.cutoffFrequency = indoorCutOff;
		}
		else
		{
			lowPassFilter.cutoffFrequency = outdoorCutOff;
		}
	}


	void OnTriggerStay(Collider col)
	{
		if(col.tag == "IndoorAudio")
		{
			indoors = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.tag == "IndoorAudio")
		{
			indoors = false;
		}
	}
}
