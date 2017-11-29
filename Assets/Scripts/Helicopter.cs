using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
    public void OnDispatchHelicopter()
    {
        Debug.Log("Heli called");
        rigidBody.velocity = new Vector3(0, 0, 50f);
    }
}

