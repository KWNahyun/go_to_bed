using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    const float Origin_Speed = 3.0f;

    public static float GlobalSpeed;
    public static float score;
    public static bool isLive;
    public GameObject uiOver;

    void Start()
    {
        isLive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLive)
        {
            score += Time.deltaTime * 2;
            GlobalSpeed = Origin_Speed + score * 0.01f;
        }
    }

    public void GameOver()
    {
        //uiOver.SetActive(true);
        isLive = false;
    }

}
