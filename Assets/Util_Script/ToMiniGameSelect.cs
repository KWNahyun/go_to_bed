using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMiniGameSelect : MonoBehaviour
{
    public void ToMiniGameSelectScene()
    {
        SceneManager.LoadScene("MiniGameSelect");
    }
}
