using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.back);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.left);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right);
		if (Input.GetKey (KeyCode.Q))
			transform.Translate (Vector3.up);
		if (Input.GetKey (KeyCode.E))
			transform.Translate (Vector3.down);
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Rotate (new Vector3 (-1f, 0f, 0f));
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Rotate (new Vector3 (1f, 0f, 0f));
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (new Vector3 (0f, -1f, 0f));
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (new Vector3 (0f, 1f, 0f));

		// Si queremos mantener la línea del horizonte siempre en horizontal,
		// hay que añadir un segundo parámetro al método Rotate para que el 
		// giro se haga respecto al sistema de coordenadas global de la escena
		// y no al local del objeto (por defecto) en los casos de LeftArrow
		// transform.Rotate (new Vector3 (0f, -1f, 0f), Space.World);
		// y RightArrow
		// transform.Rotate (new Vector3 (0f,  1f, 0f), Space.World);
	}
}
