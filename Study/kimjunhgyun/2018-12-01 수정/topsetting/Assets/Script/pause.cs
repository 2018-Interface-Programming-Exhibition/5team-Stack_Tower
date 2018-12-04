using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
    /*public static bool isPause = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        

        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
            Debug.Log(" mouseDown" + this.name);
        }
        else
        {
            Time.timeScale = 1;
            isPause = true;
        }
    }*/
    public GameObject PauseUI;
    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
        /*Vector2 pos = Camera.Main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)

        {

            //여기에 선택된 후 코드 삽입

        }*/
        //
        if (Input.GetButtonDown("Pause")) //esc눌러도 일시정지
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }



}
