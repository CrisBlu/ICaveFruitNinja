using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefab;
	public float seconds;

	[SerializeField] private AudioSource whooshSpawn;


	// Use this for initialization
	void Start () {
		seconds = Random.Range(2.2f, 3f);
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn()
    {
		for(int time = 1; time > 0; time--)
        {
			yield return new WaitForSeconds(seconds);
			whooshSpawn.Play();
        }
		GameObject fruit = prefab;
		Instantiate(fruit, this.gameObject.transform.position, Quaternion.identity);
		seconds = Random.Range(2.2f, 3f);
		StartCoroutine(Spawn());

    }



	// Update is called once per frame
	void Update () {
		


	}
}
