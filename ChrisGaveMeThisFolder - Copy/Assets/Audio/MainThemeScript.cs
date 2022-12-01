using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThemeScript : MonoBehaviour {

	public static MainThemeScript instance;

	private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
