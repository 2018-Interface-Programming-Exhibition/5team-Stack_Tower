using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour {

    public int isEnd = 0;

    private void OnCollisionEnter(Collision col)
    {
        isEnd = 1;
        Debug.Log("isEnd:" + isEnd);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
