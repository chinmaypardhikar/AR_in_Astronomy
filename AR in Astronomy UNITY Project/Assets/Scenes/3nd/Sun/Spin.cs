﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Rotate (0,0,40*Time.deltaTime); //rotates 50 degrees per second around z axis
	}
}
