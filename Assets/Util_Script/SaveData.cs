using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    public SaveData(string name, float xp, int money, float hp, float happypoint)
    {
        this.name = name;
        this.xp = xp;
        this.money = money;
        this.hp = hp;
        this.happypoint = happypoint;
    }

    // �ӽ÷� publicȭ �Ѱ��� ������ ���м��� ���� private���� ���� 
    public string name;
    public float xp;
    public int money;
    public float hp;
    public float happypoint;



}
