﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	void OnTriggerEnter (Collider col){

		if (col.tag == "Line") {
			Debug.Log ("Objet");
		}

	}
}
