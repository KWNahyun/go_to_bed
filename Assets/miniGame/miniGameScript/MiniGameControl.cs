using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MiniGameControl : MonoBehaviour
{
    public enum State { Idle, Run, Jump, Hit } 
    public float StartJumpPower;
    public float jumpPower;
    public bool isGround;
    public UnityEvent onHit;

    //������Ʈ �ҷ����� 
    Rigidbody2D rigid;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        StartJumpPower = 5.0f;
        jumpPower = 1.0f;

        anim.SetBool("isRun", true);
    }

    void Update()
    {
        if (GameManager.isLive)
        {
            // �⺻���� ���� 
            if (Input.GetButtonDown("Jump") && isGround)
            {
                rigid.AddForce(Vector2.up * StartJumpPower, ForceMode2D.Impulse);
            }
            else if (Input.GetButton("Jump") && !isGround) // �� ���� 
            {
                jumpPower = Mathf.Lerp(jumpPower, 0, 0.1f);
                rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }

        }
    }


    // ���� 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        jumpPower = 1.0f;
        anim.SetBool("isJump", false);
    }

    // �ٽ� ���� �� �� 
    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("isJump", true);
        isGround = false;
    }

    // ��ֹ� ��Ʈ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("isDie", true);
        rigid.simulated = false;

        onHit.Invoke();
    }



}
