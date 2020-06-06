using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsar : MonoBehaviour 
{
	Rigidbody rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (new Vector3 (0f, 5f, 0f), ForceMode.Impulse);
	}
}
