﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame 
	void Update () {
	//	Debug.Log(Input.mousePosition); 
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);    
		transform.position = new Vector3(transform.position.x,Mathf.Clamp(mousePos.y,-4f,4f),transform.position.z);
	}
}
