using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLobby : MonoBehaviour
{
    public AudioClip audioPop;
    AudioSource audioSource;

    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToLobbyScene()
    {
        audioSource.PlayOneShot(audioSource.clip);
        // 새로 시작할 때 static변수 초기화하기 
        GameManager.score = 0;
        GameManager.isLive = true;
        GameManager.inGameMoney = 0;


        SceneManager.LoadScene("main");
    }


}
