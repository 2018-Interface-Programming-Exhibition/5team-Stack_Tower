using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    Vector3 BarPosition;
    GameObject Bar , Aim;
    public GameObject Cloud1,AimPoint;
    Vector2 inl;
    public Transform randomT;
    public int accuracy=0;
    int flag=0;
    public Text ScoreText;
    public static int cloud_score = 0;
    public int i = 0;
    public static bool Gameover = true;
    void CreateBird()
    {

        inl = new Vector3(Aim.transform.position.x, Aim.transform.position.y, Aim.transform.position.z);
        GameObject cloud_clone = (GameObject)Instantiate(Cloud1, inl, Quaternion.identity); // 블럭 생성
        cloud_clone.tag = "Bird";
        //본체는 태그 안달고 클론만 태그 달아준다.~> clone들 태그로 충돌 구별하기 위해
        cloud_clone.name += i.ToString();//테스트용 이름달기
        i++;

     // 구름에임 투명도 넣기

    }
    void stop()//게임 끝
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Score", LoadSceneMode.Additive);
        GameObject.Find("Aim").SendMessage("flex");
        Gameover = false;
        Debug.Log("끗");
        // GameObject.Find("Aim").SendMessage("stop");

    }
    // Use this for initialization
    void Start ()
    {
      
        Bar = GameObject.Find("Bar");//오브젝트 Bar
        Aim = GameObject.Find("Aim");                         //    AimPoint = GameObject.Find("AimPoint");
        Cloud1 = GameObject.Find("Cloud1");//오브젝트 Bird1
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cloud_score++;
            ScoreText.text = cloud_score.ToString("N0");
            //N'0'-> 숫자 0임
            //ToString("NO") : 실수나 정수값을 문자값으로 변환해줌. 
            // N을 써서소수점 이하값을 표현해주지 않는다.
        }

    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.