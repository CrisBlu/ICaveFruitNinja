using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordLagCompensation : MonoBehaviour {

	public GameObject fuck;
	Vector3 currentPosition;
	Quaternion currentRotation;

	[SerializeField] private AudioSource fruitSlicing;
	Collider cutTrigger;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 previousPosition = currentPosition;
		Quaternion previousRotation = currentRotation;


		currentPosition = transform.position;
        currentRotation = transform.rotation;

		Vector3 between = previousPosition - currentPosition;

		float distance = Vector3.Distance(previousPosition, currentPosition);

		//fuck.transform.LookAt(previousPosition);
		fuck.transform.localScale = new Vector3(between.x * 100f, between.y * 100f, fuck.transform.localScale.z);
		fuck.transform.position = currentPosition + (between / 2.0f);



		if (distance < .01)
		{
			fuck.transform.localScale = new Vector3(.01f, fuck.transform.localScale.y, fuck.transform.localScale.z);

		}
	}

	private void Awake()
    {
		fruitSlicing = GetComponent<AudioSource>();
		cutTrigger = GetComponent<Collider>();
    }

	void OnTriggerEnter(Collider collider)
    {
		if (collider.gameObject.GetComponentInParent<Fruit>() != null || collider.gameObject.GetComponent<ButtonFruit>() != null)
		{
			Debug.Log("Collision");
			fruitSlicing.Play();
		}
    }

}
