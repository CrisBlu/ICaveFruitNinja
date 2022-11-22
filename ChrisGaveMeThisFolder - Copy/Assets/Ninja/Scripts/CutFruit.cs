using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFruit : MonoBehaviour {

	float xSpin = 0;
	float ySpin = 0;
	float zSpin = 0;


	// Use this for initialization
	void Start () {
		xSpin = Random.Range(-500.0f, 500.0f);
		ySpin = Random.Range(-500.0f, 500.0f);
		zSpin = Random.Range(-500.0f, 500.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(xSpin * Time.deltaTime , ySpin * Time.deltaTime , zSpin * Time.deltaTime); 
	}
}
