using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    GameObject ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, ball.transform.position.y+3, ball.transform.position.z - 10);
	}
}
