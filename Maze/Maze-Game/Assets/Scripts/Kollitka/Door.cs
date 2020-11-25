using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    [SerializeField]
    float openDoor = 0;
    [SerializeField]
    float closeDoor = 0;
    [SerializeField]
    float speed = 1;
    public bool isOpen;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isOpen) 
		{
			OpenDoor();
		} 
		else 
		{
			CloseDoor();
		}
	}
    

	void OpenDoor ()
	{
		transform.rotation = Quaternion.Slerp (transform.rotation, 
			Quaternion.Euler(transform.rotation.x, openDoor, transform.rotation.z), speed * Time.deltaTime);
	}

	void CloseDoor ()
	{
		transform.rotation = Quaternion.Slerp (transform.rotation, 
			Quaternion.Euler(transform.rotation.x, closeDoor, transform.rotation.z), speed * Time.deltaTime);
	}
}
