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
        transform.Translate(speedRate * -1f * Time.deltaTime, 0, 0);    
    }
}
