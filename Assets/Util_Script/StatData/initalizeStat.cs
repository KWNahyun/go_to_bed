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
            Debug.Log("���������� �����͸� �ʱ�ȭ �߽��ϴ�");
            SaveData stat = new SaveData("�������ǳ���", 0.0f, 50, 100.0f, 100.0f);

            SaveSystem.Save(stat, "StatDB");
        }
    }


    public void InitDataFile()
    {
        SaveData Data = SaveSystem.Load("StatDB");
        if (Data == null)
        {
            Debug.Log("StatDB�� �ʱ�ȭ �߽��ϴ�");
            SaveData stat = new SaveData("�������ǳ���", 0.0f, 50, 100.0f, 100.0f);

            SaveSystem.Save(stat, "StatDB");
        }
    }





}
