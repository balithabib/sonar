using System;
﻿using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;


public class serialcom : MonoBehaviour
{		

    public string PORT_NAME = "/dev/ttyACM1";
    public int BAUD_RATE = 9600;
    public float RangeRead = 0f;
    public int PositionRead = 0;

    SerialPort stream;
    
    // Start is called before the first frame update
    void Start()
    {
	stream = new SerialPort(PORT_NAME, BAUD_RATE);
	if(stream != null){
		if(!stream.IsOpen){
			Debug.Log("Openning ...");
			stream.Open();	
			stream.ReadTimeout = 1000;
		}else{
			Debug.Log(" Already open .");
		}
	}else{
		Debug.Log("ERROR port is not open ...");
	}
    }

    // Update is called once per frame
    void Update()
    {
	if(stream.IsOpen){
		string value = stream.ReadLine();
		Debug.Log("Reading value ... " + value);	
		PositionRead = int.Parse(value);
	}
    }



    void OnApplicationQuit(){
	Debug.Log("close ...");
	stream.Close();
    }
}
