using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Rotater : MonoBehaviour {

	// Before rendering each frame..
	void Update () 
	{
		transform.Rotate (new Vector3 (135, 0, 0) * Time.deltaTime);
	}
}	
