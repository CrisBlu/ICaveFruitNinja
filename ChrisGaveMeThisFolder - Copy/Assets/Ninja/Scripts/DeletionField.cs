using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletionField : MonoBehaviour {

	public float lostLives = 0f;
	
	// Update is called once per frame
	void Update () {
		if (lostLives < 0)
        {
			lostLives = 0;
        }
		if(lostLives >= 3f)
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}

	void OnTriggerEnter(Collider col)
    {
		if(col.gameObject.GetComponentInParent<Fruit>() != null)
        {
			if (col.gameObject.GetComponentInParent<Fruit>().gameObject.GetComponentInChildren<Bomb>() == null)
			{
				lostLives++;
			} else
            {
				lostLives--;
            }
        }

		Destroy(col.gameObject);
    }
}
