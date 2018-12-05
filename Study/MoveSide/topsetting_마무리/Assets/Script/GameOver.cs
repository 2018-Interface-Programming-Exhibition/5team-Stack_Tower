using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject GameOverUI;

    void Start()
    {
        GameOverUI.SetActive(false);
    }

    void Update()
    {
        if (ending.isEnd == 1)
        {
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Restart()
    {
        GameManager.Gameover = true;
        ending.isEnd = 0;
        GameManager.cloud_score = 0;
        SceneManager.LoadScene("SampleScene");
    }


}
