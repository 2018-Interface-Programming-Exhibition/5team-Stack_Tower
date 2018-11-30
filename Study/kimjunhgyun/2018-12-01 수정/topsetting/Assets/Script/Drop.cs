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
        GetComponent<Rigidbody2D>().AddForce(Vector2.down * 0);//시작할 때 떨어지는 속도 0
        con = 2;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (con != 0)
        {
            con = 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Transform>().position += new Vector3(0, 0.1f, 0);
           // Debug.Log(con);
        }
        
        //다시 외력작용 받게 함( 균형)
    }
    // Cloud1에서 Use Gravity를 체크한다.
    void Update () {
        Rigidbody2D myRigidbody = GetComponent<Rigidbody2D>();
        // myRigidbody.useGravity = true; //떨어지는 속도 일정  *


	}
}
