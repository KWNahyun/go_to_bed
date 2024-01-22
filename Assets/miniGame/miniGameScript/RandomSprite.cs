using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSprite : MonoBehaviour
{
    // ���� ��ֹ� ���� ��ũ��Ʈ
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
