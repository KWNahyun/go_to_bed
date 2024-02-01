using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMini : MonoBehaviour
{
    public AudioClip audioPop;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToMiniGameScene()
    {
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("minigame");
    }
    
}
