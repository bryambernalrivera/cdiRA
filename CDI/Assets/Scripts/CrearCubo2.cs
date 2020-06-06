using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo2 : MonoBehaviour 
{
	public GameObject prefab;

	void Update () 
	{
		GameObject cubo;

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			cubo = Instantiate (prefab, transform.position, transform.rotation) as GameObject;
			Destroy (cubo, 5f);
		}
	}
}
