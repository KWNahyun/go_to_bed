using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initalizeStat : MonoBehaviour
{


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            SaveData stat = new SaveData("�������ǳ���", 0.0f, 50, 100.0f, 100.0f);

            SaveSystem.Save(stat, "StatDB");
        }
    }
}
