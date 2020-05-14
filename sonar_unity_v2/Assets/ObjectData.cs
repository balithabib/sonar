using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour {
	 
	public Vector3 objectPosition;

	public GameObject objectLocationSprite;


	void Update (){

		objectPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);


	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") 
		{
			Instantiate (objectLocationSprite, new Vector3 (transform.position.x, -10, transform.position.z), Quaternion.identity);
			Debug.Log ("Object detected");
		}
	}
}