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
    
    public AudioClip audioPop;
    AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

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

        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("minigame");

        // 새로 시작할 때 static변수 초기화하기 
        score = 0;
        isLive = true;
        inGameMoney = 0;

    }

    public void toHome()
    {
        audioSource.PlayOneShot(audioSource.clip);
        GameObject.Find("StatControler").GetComponent<moneyControler>().UpdateStatPoint();
        SceneManager.LoadScene("main");
    }


}
