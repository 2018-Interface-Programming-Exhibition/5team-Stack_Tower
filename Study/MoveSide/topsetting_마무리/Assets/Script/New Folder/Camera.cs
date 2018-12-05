using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float speed = 1f;
    public GameObject Cameraposition;
    public GameObject Main;
    Transform C_P;
    Transform M_P;

    // Use this for initialization
    void Start ()
    {
        FirstCamera firstcamera = GameObject.Find("First_Position_Button").GetComponent<FirstCamera>();
        C_P = Cameraposition.transform;
        M_P = Cameraposition.transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        bool game = GameManager.Gameover;
        if (FirstCamera.Ca_Sw == false && game == true)
        {
            transform.position = new Vector3(C_P.position.x, C_P.position.y, transform.position.z);
        }
    }
}
