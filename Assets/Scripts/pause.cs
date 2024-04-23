using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool paused = false;

	public void Update()
	{
		if (Input.GetKeyDown("space")){
			paused = togglePause();
		}
	}
	
	void OnGUI()
	{
		if(paused)
		{
			GUILayout.BeginArea (new Rect (Screen.width/2 - 100, Screen.height/2, 200, 100));
        	GUILayout.Box ("Game is paused");
        	GUILayout.EndArea ();
		}
	}
	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);	
		}
	}
}