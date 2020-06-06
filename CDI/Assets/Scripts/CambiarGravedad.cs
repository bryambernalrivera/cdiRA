using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarGravedad : MonoBehaviour 
{
	public float gravedad;

	void Start () 
	{
		gravedad = -9.81f;
		Physics.gravity = new Vector3 (0f, gravedad, 0f);
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.KeypadPlus))
		{
			gravedad++;
			Physics.gravity = new Vector3 (0f, gravedad, 0f);
		}
		if (Input.GetKeyDown (KeyCode.KeypadMinus)) 
		{
			gravedad--;
			Physics.gravity = new Vector3 (0f, gravedad, 0f);
		}
	}
}
