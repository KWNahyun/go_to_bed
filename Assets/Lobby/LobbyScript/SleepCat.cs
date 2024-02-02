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
            MoveCat.isSleeping = false; // ����� 
            Debug.Log("����̸� �������ϴ�");
        }
        else
        {
            MoveCat.isSleeping = true; // ����
            Debug.Log("����̸� ������ϴ�");
        }


        // ����� , ���� (On, Off��ư)  
    } 

}
