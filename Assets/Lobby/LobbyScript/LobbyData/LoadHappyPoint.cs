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

        

        happySlider.value = Data.happypoint;

    }
}
