using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour {

	private Transform sweepTransform;
	private float rotationSpeed;

	private void Awake(){
		sweepTransform = transform.Find ("Sweep");
		rotationSpeed = 60f;
	}

	private void Update(){
		sweepTransform.eulerAngles -= new Vector3 (0, 0, rotationSpeed * Time.deltaTime);

	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Object") {
			Debug.Log ("Object");
		}
	}

}
