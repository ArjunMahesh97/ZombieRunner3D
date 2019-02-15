 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultPOV;
	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera> ();
		defaultPOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Zoom")){
			eyes.fieldOfView = defaultPOV / 1.5f;
		}else{
			eyes.fieldOfView = defaultPOV;
		}
		
	}
}
