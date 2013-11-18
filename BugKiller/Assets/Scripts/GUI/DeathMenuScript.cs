﻿using UnityEngine;
using System.Collections;

public class DeathMenuScript : MonoBehaviour {

	public GUITexture image;
	public GameObject buttonTexture;
	public string levelName = "FirstIterationDemo";

	void OnGUI()
	{
		ShowDeathMenu();
	}

	void ShowDeathMenu()
	{
		GUILayout.BeginArea(new Rect((Screen.width*0.5f-50),(Screen.height*0.5f+65),100,200));
		if(GUILayout.Button("Restart"))
		{
			//load needed level
			Player.RestorePlayer();
			Application.LoadLevel(levelName);
		}
		if(GUILayout.Button("Main Menu"))
		{
			//MainMenu
			Application.LoadLevel(0);
		}
		GUILayout.EndArea();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
