using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {
    
    public GameObject PauseUI;
    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause")) //esc눌러도 일시정지
        {
            paused = !paused;
            if (paused == true) GameManager.Gameover = false;
            else GameManager.Gameover = true;
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            GameObject.Find("Aim").SendMessage("flex");
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
        
    }

    public void Back()
    {
        paused = false;
        GameManager.Gameover = true;
    }
    public void Restart()
    {
        GameManager.Gameover = true;
        GameManager.cloud_score = 0;
        SceneManager.LoadScene("SampleScene");
    }
}