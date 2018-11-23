using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}

    public TextMesh _ScoreText;
  
	void Update () {
        _ScoreText.text = ((int)Time.timeSinceLevelLoad * 100).ToString("N0");
        //N'0'-> 숫자 0임
        //TIme.timeSinceLevelLoad : 게임씬이 시작되고나서부터의 시간을 1초 기준으로 보여줌.
        //거기다가 100 곱한만큼을 점수로 하고,
        //ToString("NO") : 실수나 정수값을 문자값으로 변환해줌. 
        // N을 써서소수점 이하값을 표현해주지 않는다.


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Warning");


        }
    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.