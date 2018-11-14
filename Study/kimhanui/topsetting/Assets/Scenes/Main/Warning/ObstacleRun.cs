using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRun : MonoBehaviour
{
    public int mouseon= 0;
    public GameObject ob;//obstacle

    private void OnMouseEnter()
    {
        Debug.Log("마우스가 오브젝트 위에 위치");
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("클릭");
            mouseon = 1;
        }

        if( mouseon ==1)
        {
            Destroy(ob);
            mouseon = 0;// 다음번에 또 장애물 나올경우를 위함
        }
    }
    
    void Start()
    {

        float xPosition = 6.5f;
        float yPosition = transform.position.y; //이후 랜덤으로 변경(탑의 높이 범위)
        transform.position = new Vector3(xPosition, yPosition, 0);
    }

   
    void Update()
    {
        float xx = transform.position.x;
        float yy = transform.position.y;
        Vector3 mousePos;
        xx = xx - 0.01f;

        transform.position = new Vector3(xx, yy, 0); //방해하러오는 중,,
                                                     /* if (Input.GetMouseButtonDown(0) == true )
                                                      //Input.GetMouseButtonDown(0) 인자에 0은 왼쪽 마우스, 1은 오른쪽 마우스, 2는 휠임
                                                      //'OnMouseDown() 함수는 모바일에서 적용되지 않는다'니 지양하도록
                                                      //하지만 문제점?: 오브젝트 뿐만 아니라 다른 곳 클릭도 통용됨 -> OnmouseEnter()
                                                     */

        if (Input.GetMouseButtonDown(0) == true)

            Debug.Log("클릭");
    }
}
