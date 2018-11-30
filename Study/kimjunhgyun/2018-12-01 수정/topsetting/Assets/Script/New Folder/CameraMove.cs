using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public static float Oj_speed = 0.1f;
    public static float Camera_speed = 1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("카메라 속도" + CameraMove.Camera_speed);
        Vector3 Oj_position = new Vector3(0, Oj_speed);
        transform.position += Oj_position * Camera_speed * Time.deltaTime;
    }
}
