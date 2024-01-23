using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    public SaveData(string name, int xp, int money, int hp, int happypoint)
    {
        this.name = name;
        this.xp = xp;
        this.money = money;
        this.hp = hp;
        this.happypoint = happypoint;
    }

    // �ӽ÷� publicȭ �Ѱ��� ������ ���м��� ���� private���� ���� 
    public string name;
    public int xp;
    public int money;
    public int hp;
    public int happypoint;



}
