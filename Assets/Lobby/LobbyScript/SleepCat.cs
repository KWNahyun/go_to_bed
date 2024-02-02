using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepCat : MonoBehaviour
{
    public AudioClip audioPop;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SetSleepingMode()
    {
        audioSource.PlayOneShot(audioSource.clip);
        if (MoveCat.isSleeping)
        {
            MoveCat.isSleeping = false; // 깨우기 
            Debug.Log("고양이를 깨웠습니다");
        }
        else
        {
            MoveCat.isSleeping = true; // 재우기
            Debug.Log("고양이를 재웠습니다");
        }


        // 깨우기 , 재우기 (On, Off버튼)  
    } 

}
