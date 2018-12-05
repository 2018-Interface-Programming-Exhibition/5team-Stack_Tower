using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour {
    int cnt = 0,flag=0,spaceFlag=0;
    public static int isEnd = 0;
    public int c = 0;
    GameObject Camera;
    //  float Camera_y;


    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Bird")//구름클론만 태그잇음 이용
        {
            if (c == 0)
            {
                Debug.Log("구름 떨어짐 게임 오버");
                isEnd = 1;
                GameObject.Find("GameManager").SendMessage("stop");

                c = 1;
            }
        }

    }


    void Start () {
        Camera = GameObject.Find("Main Camera Position");

    }
	
	// Update is called once per frame
	void Update () {
        // Camera_y = transform.localPosition.x;
        if (!(-10 <= transform.position.x && transform.position.x <= 10))//구름이 카메라 x좌표로 카메라 밖에 나갈시
        {
            if (c == 0)
            {
                isEnd = 1;
                Debug.Log("x좌표 게임 오버");
                GameObject.Find("GameManager").SendMessage("stop");

                c = 1;
            }
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
                if (c == 0)
                {
                    isEnd = 1;
                    Debug.Log("구름 안보임 게임 오버");
                    GameObject.Find("GameManager").SendMessage("stop");

                    c = 1;
                }
            }
        }
    }
}
