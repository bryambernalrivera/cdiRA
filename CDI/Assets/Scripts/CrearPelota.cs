using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPelota : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		GameObject pelota;
		if (Input.GetKeyDown (KeyCode.C)) {
			pelota = Instantiate (prefab, transform.position, transform.rotation) as GameObject;
			Destroy (pelota, 10f);
		}
	}
}
