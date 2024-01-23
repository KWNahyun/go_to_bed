using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public bool isHighScore;
    float highScore;

    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();

        if (isHighScore)
        {
            highScore = PlayerPrefs.GetFloat("Score"); // PlayerPrefs로 저장하면 데이터 save and load가 됨 
            scoreText.text = highScore.ToString("F0");
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!GameManager.isLive) return;
    
        if (isHighScore && GameManager.score < highScore) return;

        scoreText.text = GameManager.score.ToString("F0");


    }
}
