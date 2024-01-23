using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 


public class moneyControler : MonoBehaviour
{

    private int inputMoney = GameManager.inGameMoney; // ( 실제 적용 ) 
    private float minusHp = GameManager.score * 0.1f; // 일단 임시로 변수만든거 

    public void UpdateStatPoint() // 인게임 재화 업데이트 
    {

    }

    private bool IsHpBurnout() // 채력 확인 후 다 없어지면 바로 집으로 
    {

        return false;
    }
}
