﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dver1 : MonoBehaviour {
	public Texture2D zapret;
	public Texture2D galka;
	public GameObject DvEr2;
	public GameObject Pers;
	void OnGUI () {
		if (Vector3.Distance (transform.position, Pers.transform.position) <=1 ) {
			if (Keys1.d1 == false) 
			{
				GUI.DrawTexture(new Rect((Screen.width - 50)/2, (Screen.height - 50)/2,50,50),zapret);
			}
			if (Keys1.d1 == true) 
			{
				GUI.DrawTexture(new Rect((Screen.width - 50)/2, (Screen.height - 50)/2,50,50),galka);
				if (Input.GetKeyDown (KeyCode.E)) 
				{
					Destroy (DvEr2);
				}
			}

		}
	}
}
