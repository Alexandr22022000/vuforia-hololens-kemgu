using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butt : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect ()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
