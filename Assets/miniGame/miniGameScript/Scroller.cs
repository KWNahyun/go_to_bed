using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using namespace minigame;
public class Scroller : MonoBehaviour
{

    public int count;
    public float speedRate;

    void Start()
    {
        count = transform.childCount;
    }


    void Update()
    {
        if (GameManager.isLive) // 살아움직일때만 배경 이동 
        {
            float totalSpeed = GameManager.GlobalSpeed * speedRate * Time.deltaTime;
            transform.Translate(-totalSpeed, 0, 0);
        }
    }
}
