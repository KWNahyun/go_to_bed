using System.Collections;
using System.Collections.Generic;
using System.IO; // io namespace ������ ����ؾ��� 
using UnityEngine;


public class SaveSystem : MonoBehaviour
{

    private static string SavePath => Application.persistentDataPath + "/saves/";

    // ������ Save 
    public static void Save(SaveData data , string FileName)
    {
        // ������ ���翩�� ����ó�� 
        if (data == null)
        {
            Debug.Log("�����Ͱ� �������� �ʽ��ϴ�!");
            return;
        }

        // ���丮 init��� 
        if (!Directory.Exists(SavePath))
        {
            Directory.CreateDirectory(SavePath);
        }

        string saveJson = JsonUtility.ToJson(data);
        string saveFilePath = SavePath + FileName + ".json";

        File.WriteAllText(saveFilePath, saveJson); // ����
        Debug.Log("���������� ����� : " + saveFilePath);

    }

    // ������ Load 
    public static SaveData Load(string FileName)
    {

        string saveFilePath = SavePath + FileName + ".json";
        
        // ���� ���翩�� ����ó�� 
        if (!File.Exists(saveFilePath))
        {
            Debug.Log("�׷� ������ �������� �ʽ��ϴ�!!");
            return null;
        }

        string saveFile = File.ReadAllText(saveFilePath); // �б� 
        SaveData saveData = JsonUtility.FromJson<SaveData>(saveFile); // Json to class
        return saveData;

    }


}
