using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    private Camera eyes;
    private float startFov;

	// Use this for initialization
	void Start () {
        eyes = GetComponent<Camera>();
        startFov = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Zoom") )
        {
            float zoomAmount = startFov / 1.5f;
            Zoom(zoomAmount);
        }
        else
        {
            Zoom(startFov);
        }
	}

    void Zoom(float fieldOfView)
    {
        eyes.fieldOfView = fieldOfView;
    }

}
