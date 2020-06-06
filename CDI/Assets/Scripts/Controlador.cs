using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}
}
