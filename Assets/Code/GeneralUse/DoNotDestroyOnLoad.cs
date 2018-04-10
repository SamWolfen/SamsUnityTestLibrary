using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoNotDestroyOnLoad : MonoBehaviour {
    public static DoNotDestroyOnLoad control;
 


    // Use this for initialization
    void Start () {

        //this maintains persistance of objects between scenes without creating multiple instances of the same object
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {

            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
