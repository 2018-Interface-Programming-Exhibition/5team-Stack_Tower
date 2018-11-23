using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    int con = 0;
    

  /*  void Drop_on()
    {
        gameObject.GetComponent<Drop>().enabled = true;
    }
    */
    void Start () {
        GetComponent<Rigidbody>().AddForce(Vector2.down * 0);//시작할 때 떨어지는 속도 0

    }       
   
    // Cloud1에서 Use Gravity를 체크한다.
    void Update () {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        // myRigidbody.useGravity = true; //떨어지는 속도 일정  *
        GetComponent<Rigidbody>().AddForce(Vector2.down * 100 ); //속도만 관여
        con++;
        if (con > 1)
        {
            GetComponent<Rigidbody>().AddForce(Vector2.down * -100);//떨어지는 속도가 빨라지지 않도록
        }
	}
}
