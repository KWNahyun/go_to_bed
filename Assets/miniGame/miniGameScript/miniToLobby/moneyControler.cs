using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 


public class moneyControler : MonoBehaviour
{

    private int inputMoney = GameManager.inGameMoney; // ( ���� ���� ) 
    private float minusHp = GameManager.score * 0.1f; // �ϴ� �ӽ÷� ��������� 

    public void UpdateStatPoint() // �ΰ��� ��ȭ ������Ʈ 
    {

    }

    private bool IsHpBurnout() // ä�� Ȯ�� �� �� �������� �ٷ� ������ 
    {

        return false;
    }
}
