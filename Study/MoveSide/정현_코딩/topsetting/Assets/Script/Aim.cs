using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    float Aim_x, AimPoint_x;
    public GameObject AimPoint;
        // Use this for initialization
        void Start ()
        {
        AimPoint = GameObject.Find("AimPoint");
        Aim_x = transform.localPosition.x;//Aim의 x좌표
        AimPoint_x = AimPoint.transform.position.x;//AimPoint의 x좌표
    }
	
	// Update is called once per frame
	void Update () {

        Aim_x = transform.localPosition.x;//Aim의 x좌표를 매번 저장해준다
        AimPoint_x = AimPoint.transform.position.x;//AimPoint의 x좌표를 매번 저장해준다
        // Debug.Log(Aim_x);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ((AimPoint_x-2.3f)<=Aim_x&&Aim_x<= (AimPoint_x + 2.3f))//Aim이 AimPoint의 안에 있으면 새를 생성하고 AimPoint의 x좌표를 바꿔준다
            {
                Debug.Log("안에 있음");
                GameObject.Find("GameManager").SendMessage("CreateBird");
                GameObject.Find("AimPoint").SendMessage("X_PositionChange");
            }
            
        }

    }
}



