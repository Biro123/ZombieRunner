using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {

    [Tooltip("Number of Minutes per Second for sun movement")]
    public float timeScale = 60;
    
    private float rotationPerSecond;

	// Use this for initialization
	void Start () {
        float rotationPerHour = 360 / 24;        
        float rotationPerMinute = rotationPerHour / 60;
        rotationPerSecond = rotationPerMinute / 60;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(rotationPerSecond * Time.deltaTime * timeScale, 0, 0);
	}
}
