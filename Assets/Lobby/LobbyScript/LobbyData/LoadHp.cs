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
        
        // ������ ���� ���̳ʽ� ���°� �� �� 
        if (Data.hp < 0)
        {
            Data.hp = 0;
        }

        SaveSystem.Save(Data, "StatDB");

        hpSlider.value = Data.hp;


    }


}
