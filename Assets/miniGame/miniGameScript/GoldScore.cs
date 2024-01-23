using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoldScore : MonoBehaviour
{

    Text goldText;

    void Start()
    {
        goldText = GetComponent<Text>();    

    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = GameManager.inGameMoney.ToString("F0");
    }
}
