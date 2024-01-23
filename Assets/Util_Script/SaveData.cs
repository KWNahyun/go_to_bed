using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public SaveData(string name, int xp, int money, int hp, int happypoint)
    {
        this.name = name;
        this.xp = xp;
        this.money = money;
        this.hp = hp;
        this.happypoint = happypoint;
    }

    private string name;
    private int xp;
    private int money;
    private int hp;
    private int happypoint;



}
