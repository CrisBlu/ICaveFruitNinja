using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefab;
	public float seconds;
	public float scale = 1f;

	[SerializeField] private AudioSource whooshSpawn;

	// Use this for initialization
	void Start () {
		seconds = Random.Range(2.2f, 3f) * (1 / scale);
		StartCoroutine(Spawn());
		StartCoroutine(Scale());
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
		seconds = Random.Range(2.2f, 3f) * (1 / scale);
		StartCoroutine(Spawn());
    }

	IEnumerator Scale()
    {
		for(int i = 0; i < 1; i++)
        {
			yield return new WaitForSeconds(0.6f);
        }
		scale += 0.01f;
		StartCoroutine(Scale());
    }
}


