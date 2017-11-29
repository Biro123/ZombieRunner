using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject playerSpawnPoints;
    public Helicopter helicopter;
    public AudioClip whatHappened;

    private bool respawnNow = false;
    private Transform[] spawnPoints;
    private AudioSource innerVoice;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();

        AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.priority == 1)
            {
                innerVoice = audioSource;
            }
        }

        innerVoice.clip = whatHappened;
        innerVoice.Play();

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
        Debug.Log("Found Clear Area in player");
        helicopter.Call();
        // Deploy Flare
        // Start spawning zombies
    }
}
