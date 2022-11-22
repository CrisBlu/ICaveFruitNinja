using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCut : MonoBehaviour
{

    public GameObject fruitSlicedPrefab;

  

    void OnTriggerEnter(Collider col)
    {
            Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
    }
}
