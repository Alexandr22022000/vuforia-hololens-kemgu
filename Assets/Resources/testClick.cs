﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect()
    {
        gameObject.active = false;
    }
}
