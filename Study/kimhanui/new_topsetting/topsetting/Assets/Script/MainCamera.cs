using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 0, -10);
	}
	
	// Update is called once per frame
	void Update () {
        float YPosition = transform.position.y;
        YPosition = YPosition + 0.01f;
        transform.position = new Vector3(0, YPosition, -10);
	}
}
