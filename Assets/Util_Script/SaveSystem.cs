using System.Collections;
using System.Collections.Generic;
using System.IO; // io namespace 무조건 사용해야함 
using UnityEngine;


public class SaveSystem : MonoBehaviour
{

    private static string SavePath => Application.persistentDataPath + "/saves/";

    // 데이터 Save 
    public static void Save(SaveData data , string FileName)
    {
        // 데이터 존재여부 예외처리 
        if (data == null)
        {
            Debug.Log("데이터가 존재하지 않습니다!");
            return;
        }

        // 디렉토리 init경로 
        if (!Directory.Exists(SavePath))
        {
            Directory.CreateDirectory(SavePath);
        }

        string saveJson = JsonUtility.ToJson(data);
        string saveFilePath = SavePath + FileName + ".json";

        File.WriteAllText(saveFilePath, saveJson); // 쓰기
        Debug.Log("성공적으로 저장됨 : " + saveFilePath);

    }

    // 데이터 Load 
    public static SaveData Load(string FileName)
    {

        string saveFilePath = SavePath + FileName + ".json";
        
        // 파일 존재여부 예외처리 
        if (!File.Exists(saveFilePath))
        {
            Debug.Log("그런 파일은 존재하지 않습니다!!");
            return null;
        }

        string saveFile = File.ReadAllText(saveFilePath); // 읽기 
        SaveData saveData = JsonUtility.FromJson<SaveData>(saveFile); // Json to class
        return saveData;

    }


}
