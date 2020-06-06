using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour 
{
	public float impulso = 37f;
	public float alt = 29f;
	public float direcc = -4f;

	void Start () 
	{
		GetComponent<Rigidbody> ().AddForce (new Vector3 (impulso, alt, direcc), ForceMode.Impulse);
	}
}
