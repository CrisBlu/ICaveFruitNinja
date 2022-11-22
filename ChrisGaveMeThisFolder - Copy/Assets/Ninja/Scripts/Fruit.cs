using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
	public Rigidbody rb;
	bool right = true;
	Vector3 rotate;
	public GameObject[] fruits;

	// Use this for initialization
	void Start()
	{
		int randomInt = Random.Range(0, fruits.Length);
		GameObject fruit = fruits[randomInt];
		Instantiate(fruit, new Vector3(0f, 0f, 8f), Quaternion.identity, this.gameObject.transform);

		Vector3 up = Vector3.up * Random.Range(50f, 60f);
		rb.AddForce(up);
		Vector3 randomRot = new Vector3(0f, Random.Range(-145f, 135f), 0f);
		transform.eulerAngles = transform.eulerAngles + randomRot;
		if (Random.Range(0f, 100f) < 50f)
		{
			right = false;
		}
		if (right)
		{
			rotate = new Vector3(0f, Random.Range(0.1f, 0.375f), 0f);
		}
		else
		{
			rotate = new Vector3(0, Random.Range(0.1f, 0.375f) * -1, 0f);
		}
	}

	void Update()
	{
		float rotValue = transform.eulerAngles.y;
		if(rotValue > 180f)
        {
			rotValue -= 360f;
        }
		if (rotValue <= -145f || rotValue >= 135f)
        {
			rotate = rotate * -1f;
        }
		transform.eulerAngles = transform.eulerAngles + rotate;
	}

}