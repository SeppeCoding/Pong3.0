﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {
    public bool isBump1;
    public float speed = 5f;

    // Use this for initialization
    void Start () {

      
	}
	    
	// Update is called once per frame
	void Update () {
    if (isBump1)
        transform.Translate(0f, Input.GetAxis("vertical") * speed * Time.deltaTime, 0f);
    else
        transform.Translate(0f, Input.GetAxis("vertical2") * speed * Time.deltaTime, 0f);

	}
}
