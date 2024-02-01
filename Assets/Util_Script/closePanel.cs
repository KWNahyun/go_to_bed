using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
public class closePanel : MonoBehaviour
{
    public GameObject panel;
    public AudioClip audioPop;
    AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void closePause()
    {
        audioSource.PlayOneShot(audioSource.clip);
        closePage();
    }

    private void closePage()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
