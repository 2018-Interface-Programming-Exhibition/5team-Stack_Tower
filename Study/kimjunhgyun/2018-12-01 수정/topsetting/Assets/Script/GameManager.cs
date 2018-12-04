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
    void CreateBird()
  {
        if (flag == 0)
        {
            inl = new Vector3(Aim.transform.position.x, Aim.transform.position.y, Aim.transform.position.z);
            Instantiate(Cloud1, inl, Quaternion.identity); // 블럭 생성

            Renderer b_renderer = Aim.GetComponent<Renderer>();
            b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 0.5f); 
            // 구름에임 투명도 넣기

        }
        else
        {

        }
        //GameObject.Find("Bird1").SendMessage("Drop_on");
   }
    void stop()//게임 끝
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Score", LoadSceneMode.Additive);
    
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
            ScoreText.text = "Score  " + cloud_score;

            
        }

    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.