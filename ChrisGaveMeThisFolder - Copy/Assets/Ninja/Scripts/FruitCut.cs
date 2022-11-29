using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCut : MonoBehaviour
{

    public GameObject fruitSlicedPrefab;
    public DeletionField df;
    

    void Start()
    {
        df = GameObject.Find("DeletionField").GetComponent<DeletionField>();
    }
  

    void OnTriggerEnter(Collider col)
    {
            Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
            df.score += 1;
            
            Destroy(gameObject);
    }
}
