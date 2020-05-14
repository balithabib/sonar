using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class ctrl : MonoBehaviour
{

    public serialcom serialHand;
    private float distance;
    private int pos;

    public GameObject RangePrefab;
    public int MAX_ANGLE = 100;

    private float angleRad;

    private float updatePeriod = 0.0f;
 
    // Start is called before the first frame update
    void Start()
    {

	for (int i =0; i<MAX_ANGLE; i++){
		angleRad = i * Mathf.PI / 180;
		GameObject go = Instantiate(RangePrefab, new Vector3(20 * Mathf.Sin(angleRad),0,20 * Mathf.Cos(angleRad)),Quaternion.identity); 
		go.name = "C" + i;
	}
        
    }

    // Update is called once per frame
    void Update()
    {
	updatePeriod += Time.deltaTime;
	if(updatePeriod > 0.02f){
		Debug.Log("ici ...");
		distance = serialHand.RangeRead / 2;
		pos = serialHand.PositionRead;

		angleRad = pos * Mathf.PI / 180;
		RangePrefab = GameObject.Find("C" + pos);
		RangePrefab.transform.position = new Vector3(distance * Mathf.Sin(angleRad), 0, distance * Mathf.Cos(angleRad));
		updatePeriod = 0.0f;
	}
    }
}
