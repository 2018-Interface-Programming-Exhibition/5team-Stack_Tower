using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop2 : MonoBehaviour {
    public Transform randomT;
    public GameObject Bird1;
    int con = 0;
    // Use this for initialization
    void Start () {
GetComponent<Rigidbody>().AddForce(Vector2.down * 0);
    } 
	void Drop_on()
    {
        gameObject.GetComponent<Drop2>().enabled = true;
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
              //  randomT.position = new Vector3(Random.Range(-3.9f, 3.8f), 3.32f, 9.88f);
                gameObject.GetComponent<CubeMove>().enabled = false; //스크립트 해제!!!
                GetComponent<Rigidbody>().AddForce(Vector2.down * 100); //속도만 관여
                //GameObject.Find("Bird1").SendMessage("Drop_on");
               // Instantiate(Bird1, randomT.position, Quaternion.identity);
                con = 1;
            }
        }
    }
}
