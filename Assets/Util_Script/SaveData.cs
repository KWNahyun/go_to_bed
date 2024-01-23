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

    // 임시로 public화 한거임 원래는 은닉성을 위해 private형이 맞음 
    public string name;
    public float xp;
    public int money;
    public float hp;
    public float happypoint;



}
