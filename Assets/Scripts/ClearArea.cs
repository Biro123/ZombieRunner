using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0;
    private bool foundClearArea = false;

	// Update is called once per frame
	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 2f && Time.realtimeSinceStartup > 20f && ! foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player")
        {
            timeSinceLastTrigger = 0;
        }
    }

}
