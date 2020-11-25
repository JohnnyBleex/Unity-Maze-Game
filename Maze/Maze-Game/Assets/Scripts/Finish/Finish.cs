using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

	public Texture2D ruka;
	static public bool f;
	public GameObject Pers;

	void OnGUI () {

		if  (Vector3.Distance (transform.position, Pers.transform.position) <=1 ) {
			GUI.DrawTexture(new Rect((Screen.width - 50)/2, (Screen.height - 50)/2,50,50),ruka);
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				SceneManager.LoadScene ("Main Menu");
				//Application.LoadLevel (0);
			}
		}
	}
}
