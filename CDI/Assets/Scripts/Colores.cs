using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Colores : MonoBehaviour 
{
	float r, g, b;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		// Pulsación tecla Espacio
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			r = Random.value;
			g = Random.value;
			b = Random.value;
			GetComponent<Renderer> ().material.color = new Color (r, g, b);
		}

		// Pulsación tecla S
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			Renderer render = GetComponent<Renderer> ();
			if (render.shadowCastingMode == ShadowCastingMode.Off)
				render.shadowCastingMode = ShadowCastingMode.On;
			else if (render.shadowCastingMode == ShadowCastingMode.On)
				render.shadowCastingMode = ShadowCastingMode.Off;
		}
	}

	void OnGUI()
	{
		string rgb = "R: " + r.ToString("F2") + ", G: " + g.ToString("F2") + ", B: " + b.ToString("F2");
		GUI.TextField (new Rect (20, 20, 150, 20), rgb);
	}
}
