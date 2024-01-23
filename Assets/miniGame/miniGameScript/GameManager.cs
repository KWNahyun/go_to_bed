using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    const float Origin_Speed = 3.0f;

    public static float GlobalSpeed;
    public static float score;
    public static bool isLive;
    public static int inGameMoney;
    public GameObject uiOver;

    void Start()
    {
        isLive = true;
        uiOver.SetActive(false);

        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetFloat("Score", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLive)
        {
            score += Time.deltaTime * 2;
            GlobalSpeed = Origin_Speed + score * 0.01f;
        }
    }

    public void GameOver()
    {
        uiOver.SetActive(true);
        isLive = false;

        float highScore = PlayerPrefs.GetFloat("Score");
        PlayerPrefs.SetFloat("Score", Mathf.Max(highScore, score));
    }

    public void ReStart()
    {

        SceneManager.LoadScene("minigame");

        // 새로 시작할 때 static변수 초기화하기 
        score = 0;
        isLive = true;
        inGameMoney = 0;

    }

    public void ToLobby()
    {
        SceneManager.LoadScene("main");
    }

}
