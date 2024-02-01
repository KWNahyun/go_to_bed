using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMiniGameSelect : MonoBehaviour
{
    public AudioClip audioPop;
    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToMiniGameSelectScene()
    {
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("MiniGameSelect");
    }


}
