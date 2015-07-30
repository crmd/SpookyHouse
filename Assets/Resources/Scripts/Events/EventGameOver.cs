using UnityEngine;
using System.Collections;

public class EventGameOver : Event {

#if UNITY_WEBPLAYER
	public static string webplayerQuitURL = "http://camerondorman.com/2015/07/24/spookyhouse/";
#endif
	public override void Activate()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL(webplayerQuitURL);
#else
		Application.Quit();
#endif
	}
}
