using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
    public static bool isPause = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        

        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
            Debug.Log(" mouseDown" + this.name);
        }
        else
        {
            Time.timeScale = 1;
            isPause = true;
        }
    }


   
}
