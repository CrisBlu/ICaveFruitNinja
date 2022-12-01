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
		if (lostLives < 0)
        {
			lostLives = 0;
        }
		if(lostLives >= 3f)
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

		scoreText.text = score.ToString();
	}

	void OnTriggerEnter(Collider col)
    {
		if(col.gameObject.GetComponentInParent<Fruit>() != null)
        {

			if (col.gameObject.GetComponentInParent<Fruit>().gameObject.GetComponentInChildren<Bomb>() == null)
			{
				lostLives++;
				hitText.text += "X";
			} else
            {
				lostLives--;
				hitText.text = hitText.text.Substring(0, hitText.text.Length - 1);

			}

			

        }

		Destroy(col.gameObject);
    }
}
