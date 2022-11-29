using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public DeletionField df;

	void Start()
    {
		df = GameObject.Find("DeletionField").GetComponent<DeletionField>();
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.GetComponent<DeletionField>() == null)
		{
			df.lostLives++;
		}
		Destroy(this.gameObject);
	}
}
