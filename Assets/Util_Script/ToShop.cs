using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToShop : MonoBehaviour
{

    public AudioClip audioPop;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToShopScene()
    {
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("Shop");
    }
}
