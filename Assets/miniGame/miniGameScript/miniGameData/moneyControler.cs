using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class moneyControler : MonoBehaviour
{
    
    // �̴ϰ��� ����� 
    private static float minusHappyPoint = 20.0f;

    public void UpdateStatPoint() // �ΰ��� STAT(��ȭ) ������Ʈ 
    {
        // ���� ��ȭ �ҷ����� ( LOAD ) 
        SaveData Data = SaveSystem.Load("StatDB");

        // ���� ��ȭ ���� 
        // money 
        Data.money += GameManager.inGameMoney; 
        Debug.Log(Data.money);

        //hp
        Data.hp -= GameManager.score * 0.1f;
        if (Data.hp < 0)
        {
            Data.hp = 0;
            if (Data.hp <= 30)
            {
                Data.happypoint = 10;
            }
        }

        // happyPoint
        Data.happypoint -= minusHappyPoint;
        if (Data.happypoint < 0)
        {
            Data.happypoint = 0;
        }

        // xp
        Data.xp += GameManager.score * 50f;

        // JSON DB�� ��ȭ �ݿ� ( SAVE )
        SaveSystem.Save(Data, "StatDB");
        Debug.Log("�����Ͱ� ���������� ������Ʈ �Ǿ����ϴ�");
    }

    private bool IsHpBurnout() // ä�� Ȯ�� �� �� �������� �ٷ� ������ 
    {

        return false;
    }
}
