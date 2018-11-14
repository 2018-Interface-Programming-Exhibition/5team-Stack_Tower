using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPoint : MonoBehaviour {
    GameObject Bar;
    void X_PositionChange()
    {
        transform.position= new Vector3(Random.Range(-4, 4), Bar.transform.position.y, Bar.transform.position.z);//조준점의 x축위치를 랜덤으로 바꿈
    }
	// Use this for initialization
	void Start () {
        Bar = GameObject.Find("Bar");//오브젝트 Bar
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
