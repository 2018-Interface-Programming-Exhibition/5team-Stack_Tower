using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Height : MonoBehaviour {
    GameObject Bird1,Bird2;
    
	// Use this for initialization
	void Start () {
		Bird1 = GameObject.Find("Bird1");
        Bird2 = GameObject.Find("Bird2");
	}
	
	// Update is called once per frame
	void Update () {
	//	if ()//Bird2가 내려갈때
     //   {
     //       transform.position = new Vector3(, Bird1.transform.position.y + 1, 9.9f);          //x좌표 설정
     //   }
     //   else if ()//Bird1가 내려갈때
      //  {
      //      transform.position = new Vector3(0, Bird2.transform.position.y + 1, 9.9f);
      //  }
      
	}
}
