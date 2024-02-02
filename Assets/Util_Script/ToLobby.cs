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
        // ���� ������ �� static���� �ʱ�ȭ�ϱ� 
        GameManager.score = 0;
        GameManager.isLive = true;
        GameManager.inGameMoney = 0;


        SceneManager.LoadScene("main");
    }


}
