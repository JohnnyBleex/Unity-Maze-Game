﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys3 : MonoBehaviour {

	public Texture2D ruka;
	static public bool d3;
	public GameObject Pers;
	public GameObject kluch;
	void OnGUI () {

		if  (Vector3.Distance (transform.position, Pers.transform.position) <=1 ) {
			GUI.DrawTexture(new Rect((Screen.width - 50)/2, (Screen.height - 50)/2,50,50),ruka);
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				d3 = true;
				Destroy (kluch);
			}
		}
	}
}