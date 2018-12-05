using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollision : MonoBehaviour {
    int flag = 0;
    public GameObject Camera;
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (flag==0)
        { Debug.Log("부딪힘");
            if (transform.position.y>Camera.transform.position.y)
            {
                CameraMove.Camera_speed += 1f;
                Debug.Log("카메라 속도"+CameraMove.Camera_speed);
            }
            flag = 1;
        }




    }
    // Use this for initialization
    void Start () {
		Camera= GameObject.Find("Main Camera Position");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
