using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    public static float Aim_x, AimPoint_x;
    public static bool onspace = false;
    public static int cloud_cnt = 0;
    //public static int falldown=0;
        // Use this for initialization
        void Start ()
        {

        Aim_x = transform.localPosition.x;//Aim의 x좌표

    }
	
	// Update is called once per frame
	void Update () {

        Aim_x = transform.localPosition.x;//Aim의 x좌표를 매번 저장해준다

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onspace == false && FirstCamera.Ca_Sw == false)
            {
                Debug.Log("안에 있음");
            
                GameObject.Find("GameManager").SendMessage("CreateBird");

                onspace = true;
                flex();
            }
        }

    }
    void flex()
    {

        Renderer b_renderer = GetComponent<Renderer>();
        b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 0.5f);
        Aim.onspace = true;


    }
}



