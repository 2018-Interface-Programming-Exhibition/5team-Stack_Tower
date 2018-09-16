using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    int con = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false; //떨어지는 속도 일정

  
        if (con == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //myRigidbody.useGravity = true; 굳이 쓸필요없음
                gameObject.GetComponent<CubeMove>().enabled = false; //스크립트 해제!!!
                GetComponent<Rigidbody>().AddForce(Vector2.down * 100 ); //속도만 관여

                con = 1;
            }
        }
  
	}
}
