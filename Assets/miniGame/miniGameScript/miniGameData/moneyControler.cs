using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class moneyControler : MonoBehaviour
{
    
    // 미니게임 결과물 
    private static float minusHappyPoint = 20.0f;

    public void UpdateStatPoint() // 인게임 STAT(재화) 업데이트 
    {
        // 기존 재화 불러오기 ( LOAD ) 
        SaveData Data = SaveSystem.Load("StatDB");

        // 게임 재화 연산 
        // money 
        Data.money += GameManager.inGameMoney; 
        Debug.Log(Data.money);

        //hp
        Data.hp -= GameManager.score * 0.1f;

        // happyPoint
        Data.happypoint -= minusHappyPoint;

        // xp
        Data.xp += GameManager.score * 50f;

        // JSON DB에 재화 반영 ( SAVE )
        SaveSystem.Save(Data, "StatDB");
        Debug.Log("데이터가 성공적으로 업데이트 되었습니다");
    }

    private bool IsHpBurnout() // 채력 확인 후 다 없어지면 바로 집으로 
    {

        return false;
    }
}
