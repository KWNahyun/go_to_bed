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

    // 임시로 public화 한거임 원래는 은닉성을 위해 private형이 맞음 
    public string name;
    public int xp;
    public int money;
    public int hp;
    public int happypoint;



}
