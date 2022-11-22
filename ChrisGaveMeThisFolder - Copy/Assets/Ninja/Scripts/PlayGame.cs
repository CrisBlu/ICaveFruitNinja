using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	int rotationSpeed = 15;

	void Update()
	{

		// Rotation on y axis
		// be sure to capitalize Rotate or you'll get errors
		transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log("Hello");
    }
}
