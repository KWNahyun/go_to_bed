using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveLoad : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            SaveData stat = new SaveData("À¯Àç¸²", 10, 1, 1, 1);

            SaveSystem.Save(stat, "OnlyTest_001");
        }

        if (Input.GetKeyDown("a"))
        {
            SaveData loadData = SaveSystem.Load("OnlyTest_001");
            Debug.Log(string.Format("LoadData Result => {0},{1},{2},{3},{4}", 
                loadData.name, loadData.xp,
                loadData.money, loadData.hp, 
                loadData.happypoint ));


        }
    }
}
