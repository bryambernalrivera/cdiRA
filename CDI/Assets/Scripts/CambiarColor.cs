using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CambiarColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color color = new Color(1f,1f,1f);
		GetComponent<Renderer> ().material.color = color;
	}
}
