using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOvers : MonoBehaviour {
    public static bool on = false;
    // Use this for initialization
    void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	

	}
    void gameover()
    {
        
            Debug.Log("게임이 끝났다");
            gameObject.SetActive(true);
        
    }
}
