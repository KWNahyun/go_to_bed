using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniGameScore : MonoBehaviour
{
    public bool isHighScore;
    float highScore;

    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
