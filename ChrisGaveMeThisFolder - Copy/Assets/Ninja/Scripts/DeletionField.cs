using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletionField : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
    {
		Destroy(col.gameObject);
    }
}
