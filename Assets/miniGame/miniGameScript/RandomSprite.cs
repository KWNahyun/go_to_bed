using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSprite : MonoBehaviour
{
    // 랜덤 장애물 생성 스크립트
    public Sprite[] sprites; 
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Change();
    }

    public void Change()
    {
        int r = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[r];
    }



}
