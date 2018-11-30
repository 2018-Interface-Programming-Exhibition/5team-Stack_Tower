using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove: MonoBehaviour {
    float delta = 0.1f;

	// Use this for initialization
	void Start () {
        
	}
	void stop()
    {
        Time.timeScale = 0;
    }
	// Update is called once per frame
	void Update ()
    {

        float newXPosition = transform.position.x + delta;
        transform.position = new Vector3(newXPosition, transform.position.y, 0);

        if ( newXPosition < -1.5f )
        {
            delta *=(-1);
            Aim.onspace = false;
            if (FirstCamera.Ca_Sw == false) // 투명도 복구
            {
                Renderer b_renderer = this.GetComponent<Renderer>();
                b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 1f);
            }
             
        }
        else if( newXPosition > 1.5f)
        {           
            delta *= (-1);
            Aim.onspace = false;
            if (FirstCamera.Ca_Sw == false) // 투명도 복구
            {
                Renderer b_renderer = this.GetComponent<Renderer>();
                b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 1f);
            }
        }
    }
}
