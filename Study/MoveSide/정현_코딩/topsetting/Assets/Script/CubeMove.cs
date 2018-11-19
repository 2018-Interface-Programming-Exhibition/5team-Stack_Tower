using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove: MonoBehaviour {
    float delta = 0.1f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        float newXPosition = transform.position.x + delta;
        transform.position = new Vector3(newXPosition, transform.position.y, 0);

        if ( newXPosition < -4.0f )
        {
            delta *=(-1);
            Aim.onspace = false;
        }
        else if( newXPosition > 4.0f)
        {
            
            delta *= (-1);
            Aim.onspace = false;
        }
    }
}
