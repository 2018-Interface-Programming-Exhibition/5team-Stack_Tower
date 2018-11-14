using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCounter : MonoBehaviour {

    public GameObject[] Birds;
    int cnt = 0;

    private void OnCollisionEnter(Collision collision)
    {
  
        if (collision.gameObject.tag == "Bird") // "Bird"와 충돌 했을 때 다음 "Bird"로 대상 이동
        {

        }

        Debug.Log(++cnt);

    }


    // Use this for initialization
    void Start()
    {

        //Birds = GameObject.FindGameObjectsWithTag("Bird");

        /*for(int i=0;i< transform.childCount; i++)  //부모에서 가져오기는 일단 포기
        {
            transform.GetChild(i);
        }*/
    }    	
	// Update is called once per frame
	void Update () {
		
	}
}
