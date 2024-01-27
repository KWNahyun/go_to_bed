using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class xpTableParsing
{
    private Dictionary<int, int> experienceTable;

    public xpTableParsing()
    {
        experienceTable = new Dictionary<int, int>();
        LoadExperienceTable();
    }


    private void LoadExperienceTable()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "experience_table.json");

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            experienceTable = JsonUtility.FromJson<Dictionary<int, int>>(json);
        }
        else
        {
            Debug.LogError("Experience table JSON file not found.");
        }
    }


    // 레벨로 경험치 가져오기 
    public int GetExperienceForLevel(int level)
    {
        if (experienceTable.ContainsKey(level))
        {
            return experienceTable[level];
        }
        return 0;
    }
}
