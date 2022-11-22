using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletionField : MonoBehaviour {

	public float lostLives = 0f;
	
	// Update is called once per frame
	void Update () {
		if(lostLives >= 3f)
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}

	void OnCollisionEnter(Collision col)
    {
		if(col.gameObject.GetComponentInParent<Fruit>() != null)
        {
			lostLives++;
        }

		Destroy(col.gameObject);
    }
}
