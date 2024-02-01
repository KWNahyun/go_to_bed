using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openPanel : MonoBehaviour
{
    
    public GameObject panel;

    public void openPause()
    {
        panel.SetActive(true);
    }

}
