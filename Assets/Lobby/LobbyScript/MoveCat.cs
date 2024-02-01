using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour
{
    public int move_delay;	// ���� �̵������� ������ �ð�
    public int move_time;	// �̵� �ð�

    float speed_x;	// x�� ���� �̵� �ӵ�
    float speed_y;	// y�� ���� �̵� �ӵ�
    bool isWandering;
    bool isWalking;

    SpriteRenderer sprite;
    Animator anim;


    void Awake()
    {
        Time.timeScale = 1; // �̴ϰ��ӿ��� ���� ���������� ��� �ڵ尡 ���� ������ �����ذ� 
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        isWandering = false;
        isWalking = false;
    }


    void FixedUpdate()
    {
        if (!isWandering)
            StartCoroutine(Wander());	// �ڷ�ƾ ����
        
        if (isWalking)
            Move();
    }


    void Move()
    {
        if (speed_x != 0)
            sprite.flipX = speed_x < 0; // x�� �ӵ��� ���� Spite �̹����� ������

        transform.Translate(speed_x, speed_y, speed_y);	// ���� �̵�
    }


    IEnumerator Wander()
    {
        move_delay = 6;
        move_time = 3;

        // Translate�� �̵��� �� Object�� �ڷ���Ʈ �ϴ� ���� �����ϱ� ���� Time.deltaTime�� ������
        speed_x = Random.Range(-0.8f, 0.8f) * Time.deltaTime;
        speed_y = Random.Range(-0.8f, 0.8f) * Time.deltaTime;

        isWandering = true;

        yield return new WaitForSeconds(move_delay);

        isWalking = true;
        anim.SetBool("isWalk", true);	// �̵� �ִϸ��̼� ����

        yield return new WaitForSeconds(move_time);

        isWalking = false;
        anim.SetBool("isWalk", false);	// �̵� �ִϸ��̼� ����


        isWandering = false;
    }



}
