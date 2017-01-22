﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("LoadMainMenu", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void LoadMainMenu() {
        EditorSceneManager.LoadScene("MainMenu");
    }
}
