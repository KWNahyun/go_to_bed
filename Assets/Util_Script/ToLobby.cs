using System.Collections;
using System.Collections.Generic;
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
        SceneManager.LoadScene("main");
    }


}
