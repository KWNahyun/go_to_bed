using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closePause : MonoBehaviour
{
    public GameObject pausePanel;
    
    
    public void closePanel()
    {
        pausePanel.SetActive(false);
    }

    public void openPanel()
    {
        pausePanel.SetActive(true);
    }
}
