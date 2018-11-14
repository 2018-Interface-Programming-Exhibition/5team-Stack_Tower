using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public static float Oj_speed = 1f; // 카메라 이동 속도
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 Oj_position = new Vector3(0, Oj_speed); // 카메라 이동
        transform.position += Oj_position * 1f * Time.deltaTime;
    }
}
