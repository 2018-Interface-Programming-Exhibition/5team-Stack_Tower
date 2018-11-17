using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    Vector3 BarPosition;
    GameObject Bar , Aim;
    public GameObject Bird1,AimPoint;
    Vector2 inl;
    public Transform randomT;
    public int accuracy=0;
    int flag=0;

    void CreateBird()
  {
        if (flag == 0)
        {
            inl = new Vector3(Aim.transform.position.x, Aim.transform.position.y, Aim.transform.position.z);
            Instantiate(Bird1, inl, Quaternion.identity);
        }
        else
        {

        }
        //GameObject.Find("Bird1").SendMessage("Drop_on");
   }
    // Use this for initialization
    void Start ()
    {
        Bar = GameObject.Find("Bar");//오브젝트 Bar
        Aim = GameObject.Find("Aim");                         //    AimPoint = GameObject.Find("AimPoint");
        Bird1 = GameObject.Find("Bird1");//오브젝트 Bird1
    }

	// Update is called once per frame
	void Update () {


    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.