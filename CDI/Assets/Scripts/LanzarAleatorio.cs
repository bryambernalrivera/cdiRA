using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarAleatorio : MonoBehaviour 
{
	public float impulso = 100f;

	void Start () 
	{
		Vector3 v = new Vector3 (impulso + Random.Range (-1f, 1f), Random.Range (-10f, 10f), Random.Range (-10f, 10f));
		GetComponent<Rigidbody> ().AddForce (v, ForceMode.Impulse);
	}
}
