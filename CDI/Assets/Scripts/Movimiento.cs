﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	public float velocidad;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0f, 10f, 0f) * velocidad * Time.deltaTime);
		transform.Translate (new Vector3 (0f, 0f, 1f));
	}
}
