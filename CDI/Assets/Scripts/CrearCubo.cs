﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo : MonoBehaviour 
{
	public GameObject prefab;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Instantiate (prefab, transform.position, transform.rotation);
		}
	}
}
