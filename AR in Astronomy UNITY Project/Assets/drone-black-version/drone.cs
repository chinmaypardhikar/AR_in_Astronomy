﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Rotate (0,10000*Time.deltaTime,0); //rotates 50 degrees per second around z axis
	}
}
