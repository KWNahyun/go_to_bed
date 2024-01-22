using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameControl : MonoBehaviour
{
    public enum State { Idle, Run, Jump, Hit } 
    public float StartJumpPower;
    public float jumpPower;
    public bool isGround;

    //������Ʈ �ҷ����� 
    Rigidbody2D rigid;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        StartJumpPower = 12.0f;
        jumpPower = 1.0f;

        anim.SetBool("isRun", true);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector2.up * StartJumpPower, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        anim.SetBool("isJump", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("isJump", true);
        isGround = false;
    }

    // �ؾ��� �� 
    // 1.���� ( �� ������ �� ���� )
    // 2.����
    // 3.��ֹ� ��Ʈ 
    // 4.�ִϸ��̼� ���� 
    // 5.���� �۾� 

}
