using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    void OnMakeInitialHeliCall()
    {
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("PlayReply", initialHeliCall.length + 1f);

        BroadcastMessage("OnDispatchHelicopter");
    }

    void PlayReply()
    {
        audioSource.clip = initialCallReply;
        audioSource.Play();        
    }
}
