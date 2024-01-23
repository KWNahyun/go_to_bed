using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveLoad : MonoBehaviour
{
    private void Update()
    {
        // 세이브 예시 
        if (Input.GetKeyDown("s"))
        {
            SaveData stat = new SaveData("유재림", 10, 1, 1, 1);

            SaveSystem.Save(stat, "OnlyTest_001");
        }

        // 로드 예시 
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
