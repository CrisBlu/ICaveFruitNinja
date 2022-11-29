using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeletionField : MonoBehaviour {

	public float lostLives = 0f;
	public float score = 0;
	public Text scoreText;
	public Text hitText;



	// Update is called once per frame
	void Update () {
		if(lostLives >= 3f)
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

		scoreText.text = score.ToString();
	}

	void OnCollisionEnter(Collision col)
    {
		if(col.gameObject.GetComponentInParent<Fruit>() != null)
        {
			lostLives++;

			hitText.text += "X";
        }

		Destroy(col.gameObject);
    }
}
