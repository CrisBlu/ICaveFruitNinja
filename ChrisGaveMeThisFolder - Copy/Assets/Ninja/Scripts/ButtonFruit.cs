using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonFruit : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0, 0, 50 * Time.deltaTime); //rotates 50 degrees per second around z axis
	}

	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(SceneSwap());
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	IEnumerator SceneSwap()
    {

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
