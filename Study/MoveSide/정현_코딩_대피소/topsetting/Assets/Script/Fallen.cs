using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallen : MonoBehaviour {
    int con = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bird"|| collision.gameObject.tag == "Bird2")
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            //서로 닿았을 때 밀림 방지
            con = 1;
        }
        collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        //다시 외력작용 받게 함( 균형)
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
