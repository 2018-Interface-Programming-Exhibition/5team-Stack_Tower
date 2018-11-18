using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    public static float Aim_x, AimPoint_x;
    public static bool onspace = false;
        // Use this for initialization
        void Start ()
        {

        Aim_x = transform.localPosition.x;//Aim의 x좌표

    }
	
	// Update is called once per frame
	void Update () {

        Aim_x = transform.localPosition.x;//Aim의 x좌표를 매번 저장해준다

        // Debug.Log(Aim_x);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onspace == false)
            {
                Debug.Log("안에 있음");
                GameObject.Find("GameManager").SendMessage("CreateBird");
                onspace = true;
            }
        }

    }
}



