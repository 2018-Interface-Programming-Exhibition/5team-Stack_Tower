using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour {
    int cnt = 0,flag=0,spaceFlag=0;
    public int isEnd = 0;
    GameObject Camera;
  //  float Camera_y;
    void OnTriggerEnter2D(Collider2D col)
    {

       
         isEnd = 1;
         Debug.Log("isEnd:" + isEnd);
        

    }
    void Start () {
        Camera = GameObject.Find("Main Camera Position");

    }
	
	// Update is called once per frame
	void Update () {
       // Camera_y = transform.localPosition.x;
        if(!(-10<=transform.position.x&& transform.position.x<=10))//구름이 카메라 x좌표로 카메라 밖에 나갈시
        {
            Debug.Log("x좌표 게임 오버");
        }






        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cnt>=0)
            {
                flag = 1;
            }
            cnt++;                   
        }
        if(flag==0)
        {
            if(transform.position.y+5<Camera.transform.position.y)//카메라로 볼때 구름이 안보일시
            {
                Debug.Log("카메라 게임 오버");
            }
        }
    }
}
