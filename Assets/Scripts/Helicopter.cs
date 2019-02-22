using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;

	private bool called = false;
	private AudioSource audiosource;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
		rigidBody = GetComponent<Rigidbody> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Call(){
		if(!called){
			called=true;
			audiosource.clip = callSound;
			audiosource.Play ();
			rigidBody.velocity = new Vector3 (0, 0, 50f);
		}
	}
		
}
