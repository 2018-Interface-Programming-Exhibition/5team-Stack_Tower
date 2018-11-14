using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float speed = 1f;
    public GameObject Cameraposition;
    public GameObject Main;
    public static float limit;
    Transform C_P;
    Transform M_P;
    FirstCamera firstcamera = GameObject.Find("First_Position_Button").GetComponent<FirstCamera>();
    // Use this for initialization
    void Start ()
    {
        C_P = Cameraposition.transform;
        M_P = Main.transform;
    }
    void Update()
    {
        limit = (float)C_P.position.y - M_P.position.y;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (limit < 5.0)
        {
            if (FirstCamera.Ca_Sw == false)
            {

                transform.position = new Vector3(C_P.position.x, C_P.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(M_P.position.x, M_P.position.y, -10);
            }
        }
        else
        {

        }
    }
    void OnMouseUp()
    {

        
    }
}
