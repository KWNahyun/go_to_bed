using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHp : MonoBehaviour
{

    [SerializeField]
    private Slider hpSlider;


    private void Start()
    {
        // Load Json Data
        SaveData Data = SaveSystem.Load("StatDB");
        
        // 점수가 높아 마이너스 상태가 될 때 
        if (Data.hp < 0)
        {
            Data.hp = 0;
        }

        SaveSystem.Save(Data, "StatDB");

        hpSlider.value = Data.hp;


    }


}
