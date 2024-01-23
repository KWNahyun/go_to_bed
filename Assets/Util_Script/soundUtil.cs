using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundUtil : MonoBehaviour
{

    public AudioSource soundSource;
    public static AudioClip soundClip;

    private void Start()
    {
        soundClip = GetComponent<AudioClip>();
        soundSource = GetComponent<AudioSource>();
    }

}
