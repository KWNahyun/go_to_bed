using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMini : MonoBehaviour
{

    public void ToMiniGameScene()
    {
        SceneManager.LoadScene("minigame");
    }
    
}