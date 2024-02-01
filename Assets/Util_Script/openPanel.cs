using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openPanel : MonoBehaviour
{
    
    public GameObject panel;
    public AudioClip audioPop;
    AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void openPause()
    {
        audioSource.PlayOneShot(audioSource.clip);
        panel.SetActive(true);
        Time.timeScale = 0;
    }

}
