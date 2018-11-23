using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObCameraPosition : MonoBehaviour {
    public GameObject Ob; //inspector 창에서 할당을 통해 사용가능!!
	// Use this for initialization
	void Start () {

        float xP=transform.position.x;
        float yP = transform.position.y;
        float zP = transform.position.z;
        transform.position = new Vector3(xP, yP, zP);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
