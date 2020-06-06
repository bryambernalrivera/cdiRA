using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour 
{
	void OnCollisionEnter(Collision c)
	{
		GameObject obj = c.gameObject;

		Debug.Log ("Choque con: " + obj.name);
		GetComponent<Renderer> ().material.color = Color.black;
		Destroy (gameObject, 2f);

		obj.GetComponent<Renderer> ().material.color = Color.white;
		Destroy (obj, 1f);
	}
}
