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
            Debug.Log("성공적으로 데이터를 초기화 했습니다");
            SaveData stat = new SaveData("팀장은권나현", 0.0f, 50, 100.0f, 100.0f);

            SaveSystem.Save(stat, "StatDB");
        }
    }
}
