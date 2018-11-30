using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    Vector3 BarPosition;
    GameObject Bar;
    public GameObject Bird1,AimPoint;
    public Transform randomT;
    float x;
    int flag=0;

    void CreateBird()
    {
        if (flag == 0)
        {
            randomT.position = new Vector3(0, Bar.transform.position.y, Bar.transform.position.z);
            Instantiate(Bird1, randomT.position, Quaternion.identity);
            x = 0;
            flag = 1;
        }
        else
        {
            randomT.position = new Vector3(x, Bar.transform.position.y, Bar.transform.position.z);
            Instantiate(Bird1, randomT.position, Quaternion.identity);
        }
        
        //GameObject.Find("Bird1").SendMessage("Drop_on");
   }
    void CreateL()
    {
        if (flag == 0)
        {
            randomT.position = new Vector3(0, Bar.transform.position.y, Bar.transform.position.z);
            Instantiate(Bird1, randomT.position, Quaternion.identity);
            x = 0;
            flag = 1;
            Debug.Log(flag);
        }
        else
        {
            Debug.Log(flag);
            Debug.Log(x);
            randomT.position = new Vector3(x-0.5f, Bar.transform.position.y, Bar.transform.position.z);
            x = x - 0.5f;
            Instantiate(Bird1, randomT.position, Quaternion.identity);            
        }
    }
    void CreateR()
    {
        if (flag == 0)
        {
            randomT.position = new Vector3(0, Bar.transform.position.y, Bar.transform.position.z);
            Instantiate(Bird1, randomT.position, Quaternion.identity);
            x = 0;
            flag = 1;
            Debug.Log(flag);
        }
        else
        {
            Debug.Log(flag);
            Debug.Log(x);
            randomT.position = new Vector3(x + 0.5f, Bar.transform.position.y, Bar.transform.position.z);
            x = x + 0.5f;
            Instantiate(Bird1, randomT.position, Quaternion.identity);
        }
    }
    // Use this for initialization
    void Start ()
    {
        Bar = GameObject.Find("Bar");//오브젝트 Bar
                                 //    AimPoint = GameObject.Find("AimPoint");
        Bird1 = GameObject.Find("Bird1");//오브젝트 Bird1

    }

	// Update is called once per frame
	void Update () {
        

    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.