﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Camera cam1;
    public Camera cam2;

	// Use this for initialization
	void Start () {
        cam1.enabled = true;
        cam2.enabled = false;
        cam2.GetComponent<AudioListener>().enabled = cam2.enabled;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.C)) {
            changeCamera();
        }
	}

    public void changeCamera() {
        if(Time.timeScale != 0) {
            cam1.enabled = !cam1.enabled;
            cam1.GetComponent<AudioListener>().enabled = cam1.enabled;
            cam2.enabled = !cam2.enabled;
            cam2.GetComponent<AudioListener>().enabled = cam2.enabled;
        }
    }
}
