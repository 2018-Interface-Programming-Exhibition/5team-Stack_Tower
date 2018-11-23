using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRun : MonoBehaviour
{
    public int mouse = 0;
    public GameObject ob;//obstacle

    /*private void OnMouseUp()
    {
        Debug.Log("마우스가 오브젝트 클릭UP");
        mouse = 1;//아무데서나 떼도 ㄱㅊ
    }
    private void OnMouseDown()
    {
        if (mouse == 1)
        {
            Debug.Log("마우스가 오브젝트 클릭뗌");
            Destroy(ob);//뗼 때까지 못기다림
        }
    }*/

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
                                                     
        
        mousePos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) //고작 클릭구현에 raycast사용함
        {
            if (mousePos == Input.mousePosition)
            {
                Ray ray = Camera.main.ScreenPointToRay(mousePos);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    Debug.Log(hit.collider.gameObject);
                    Debug.DrawLine(ray.origin, ray.direction);
                    //hit.collider.gameObject.GetComponent<Renderer>().enabled = false;
                    if(hit.collider.gameObject == ob)
                        Destroy(hit.collider.gameObject);

                }
            }
        }
    }

}