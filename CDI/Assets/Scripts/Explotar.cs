using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotar : MonoBehaviour 
{
	void OnTriggerEnter(Collider c)
	{
		Debug.Log ("Entra");
		c.gameObject.GetComponent<Rigidbody>().AddForce (new Vector3 (0f, 50f, 0f), ForceMode.Impulse);
	}
}
