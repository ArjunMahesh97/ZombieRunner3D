using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints;
	public Helicopter helicopter;
	public AudioClip whatHappened;

	private Transform[] spawnPoints;
	private bool lastToggle = false;
	private bool reSpawn=false;
	private AudioSource innerVoice;

	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
		AudioSource[] audiosources = GetComponents<AudioSource> (); 
		foreach (AudioSource audioSource in audiosources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = whatHappened;
		innerVoice.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != reSpawn) {
			Respawn (); 
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}
		
	}
	private void Respawn(){
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

	void OnFindClearArea(){
		helicopter.Call ();
	}
}
