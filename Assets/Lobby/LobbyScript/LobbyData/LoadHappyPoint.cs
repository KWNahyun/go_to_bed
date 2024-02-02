using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHappyPoint : MonoBehaviour
{
    [SerializeField]
    private Slider happySlider;

    private void Start()
    {
        // Load Json Data
        SaveData Data = SaveSystem.Load("StatDB");

        if(Data.happypoint < 0)
        {
            Data.happypoint = 0;
        }

        SaveSystem.Save(Data, "StatDB");
        happySlider.value = Data.happypoint;

    }
}
