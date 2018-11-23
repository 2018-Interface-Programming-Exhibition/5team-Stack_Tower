using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public static float Oj_speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 Oj_position = new Vector3(0, Oj_speed);
        transform.position += Oj_position * 1f * Time.deltaTime;
    }
}
