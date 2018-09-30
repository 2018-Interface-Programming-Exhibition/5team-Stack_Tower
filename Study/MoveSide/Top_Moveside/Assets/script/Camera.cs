using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float speed = 1f;
    public GameObject Cameraposition;
    public GameObject Main;
    Transform C_P;
    Transform M_P;
    FirstCamera firstcamera = GameObject.Find("First Position Button").GetComponent<FirstCamera>();
    // Use this for initialization
    void Start ()
    {
        C_P = Cameraposition.transform;
        M_P = Cameraposition.transform;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (firstcamera.Ca_Sw == false)
        {
            Vector3 moveCamera = new Vector3(0, speed);
            transform.position += moveCamera * 1f * Time.deltaTime;
            transform.position = new Vector3(C_P.position.x, C_P.position.y, transform.position.z);
        }
    }
}
