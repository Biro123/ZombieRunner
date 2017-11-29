using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject playerSpawnPoints;

    private bool respawnNow = false;
    private Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();             
    }
	
	// Update is called once per frame
	void Update () {
        if (respawnNow)
        {
            ReSpawn();
            respawnNow = false;
        }
	}

    public void ReSpawn()
    {
        // instance 0 is the parent's transform - so ignore.
        int spawnInstance = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[spawnInstance].transform.position;
    }

    private void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        // TODO Drop A Flare
        Debug.Log("Dropping Flare");
    }
}
