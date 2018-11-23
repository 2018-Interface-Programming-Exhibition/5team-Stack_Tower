using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCounter : MonoBehaviour {

    public GameObject[] Birds;

	// Use this for initialization
	void Start () {
        
        //Birds = GameObject.FindGameObjectsWithTag("Bird");
        
        for(int i=0;i< transform.childCount; i++)
        {
            transform.GetChild(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
