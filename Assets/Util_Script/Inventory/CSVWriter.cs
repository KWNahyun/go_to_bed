using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class CSVManager : MonoBehaviour
{
    public string fileName = "ItemSave.csv";

    public InputField itemIDText;
    public InputField itemCountText;

    List<string[]> data = new List<string[]>();
    string[] tempData;

    void Awake()
    {
        data.Clear();

        tempData = new string[2];
        tempData[0] = "itemID";
        tempData[1] = "itemCount";
        data.Add(tempData);
    }

    public void SaveCSVFile()
    {
        tempData = new string[2];
        tempData[0] = itemIDText.text;
        tempData[1] = itemCountText.text;
        data.Add(tempData);

        string[][] output = new string[data.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = data[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            sb.AppendLine(string.Join(delimiter, output[i]));
        }
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        path = Path.Combine(Application.persistentDataPath, "Resources/");
        string filepath = Path.Combine(path, fileName); ;

        if (!Directory.Exists(filepath))
        {
            Directory.CreateDirectory(filepath);
        }

        StreamWriter outStream = System.IO.File.CreateText(filepath + fileName);
        outStream.Write(sb);
        outStream.Close();
    }
}