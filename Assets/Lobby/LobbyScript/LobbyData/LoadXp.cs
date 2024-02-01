using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadXp : MonoBehaviour
{
    [SerializeField]
    private Slider xpSlider;

    private void Start()
    {
        // Load Json Data
        SaveData Data = SaveSystem.Load("StatDB");



        xpSlider.value = Data.xp;

    }
}
