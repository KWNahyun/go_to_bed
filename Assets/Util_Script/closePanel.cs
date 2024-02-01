using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class closePanel : MonoBehaviour
{
   public GameObject panel;
   public void closePause()
    {
        panel.SetActive(false);
    }
}
