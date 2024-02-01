using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class moneyControler : MonoBehaviour
{
    
    // �̴ϰ��� ����� 
    private static float minusHp = GameManager.score * 0.1f; // �ϴ� �ӽ÷� ��������� 
    private static float minusHappyPoint = 20.0f;
    private static float plusXp = GameManager.score * 50f;


    public void UpdateStatPoint() // �ΰ��� STAT(��ȭ) ������Ʈ 
    {
        // ���� ��ȭ �ҷ����� ( LOAD ) 
        SaveData Data = SaveSystem.Load("StatDB");

        // ���� ��ȭ ���� 
        // money 
        Data.money += GameManager.inGameMoney;

        // happyPoint 
        if (Data.hp <= 50)
        {
            Data.happypoint -= 20.0f;
            if (Data.happypoint < 0)
            {
                Data.happypoint = 0;
            }
        }

        // hp
        Data.hp -= minusHp;

        // xp 
        Data.xp += plusXp;


        Debug.Log(Data.money); 

        // JSON DB�� ��ȭ �ݿ� ( SAVE )
        SaveSystem.Save(Data, "StatDB");
        Debug.Log("�����Ͱ� ���������� ������Ʈ �Ǿ����ϴ�");
    }

    private bool IsHpBurnout() // ä�� Ȯ�� �� �� �������� �ٷ� ������ 
    {

        return false;
    }
}
