using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMoney : MonoBehaviour
{

    Text moneyUI;

    private void Start()
    {
        moneyUI = GetComponent<Text>();

        // Load Json Data
        SaveData Data = SaveSystem.Load("StatDB");

        // display money Data 
        moneyUI.text = Data.money.ToString("F0");
    }


}
