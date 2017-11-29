using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0;

	// Update is called once per frame
	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 2f && Time.realtimeSinceStartup > 10f)
        {
            SendMessageUpwards("OnFindClearArea");
        }
	}

    private void OnTriggerStay(Collider other)
    {
        timeSinceLastTrigger = 0;
    }

}
