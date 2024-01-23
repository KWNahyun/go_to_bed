using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfMini : MonoBehaviour
{
    public enum Sfx { Jump, Land, Hit }
    public AudioClip[] clips;
    AudioSource audios;

    void Start()
    {
        audios = GetComponent<AudioSource>();
    }

    public void playSound(Sfx sfx)
    {
        audios.clip = clips[(int)sfx];
        audios.Play();
    }


}
