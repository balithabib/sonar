using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar3d : MonoBehaviour {

	private Transform collisionTransform;
	private float rotationSpeed;

	private void Awake(){
		collisionTransform = transform.Find ("Cube");
		rotationSpeed = 60f;
	}

	private void Update(){
		collisionTransform.eulerAngles += new Vector3 (0, rotationSpeed * Time.deltaTime, 0);

	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Object") {
			Debug.Log ("Object");
		}
	}

}
