using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveCat : MonoBehaviour
{
    public int move_delay;	// ���� �̵������� ������ �ð�
    public int move_time;	// �̵� �ð�

    float speed_x;	// x�� ���� �̵� �ӵ�
    float speed_y;	// y�� ���� �̵� �ӵ�
    bool isWandering;
    public static bool isWalking;
    public static bool isSleeping;

    int BotheredStack = 0; // �ǰ� ����

    SpriteRenderer sprite;
    Animator anim;

    [SerializeField] private Slider xpSlider;
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Slider happyPointSlider;

    //���� ���
    public AudioClip audioPop;
    AudioSource audioSource;

    void Awake()
    {
        Time.timeScale = 1; // �̴ϰ��ӿ��� ���� ���������� ��� �ڵ尡 ���� ������ �����ذ� 
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        isWandering = false;
        isWalking = false;
    }


    void FixedUpdate()
    {
        if (!isSleeping)
        {
            anim.SetBool("isSleep", false); // �Ͼ ��� 
            if (!isWandering)
                StartCoroutine(Wander());   // �ڷ�ƾ ����

            if (isWalking)
                Move();
        }
        else //  �ڰ� ������ 
        {
            speed_x = 0;
            speed_y = 0;
            anim.SetBool("isSleep", true); // �ڴ� ��� 


        }


    }


    void Move()
    {
        if (speed_x != 0)
            sprite.flipX = speed_x < 0; // x�� �ӵ��� ���� Spite �̹����� ������

        transform.Translate(speed_x, speed_y, speed_y);	// ���� �̵�
    }


    IEnumerator Wander()
    {
        move_delay = 2;
        move_time = 3;

        // Translate�� �̵��� �� Object�� �ڷ���Ʈ �ϴ� ���� �����ϱ� ���� Time.deltaTime�� ������
        speed_x = Random.Range(-1.8f, 1.8f) * Time.deltaTime;
        speed_y = Random.Range(-1.8f, 1.8f) * Time.deltaTime;

        isWandering = true;

        yield return new WaitForSeconds(move_delay);

        isWalking = true;
        anim.SetBool("isWalk", true);	// �̵� �ִϸ��̼� ����

        yield return new WaitForSeconds(move_time);

        isWalking = false;
        anim.SetBool("isWalk", false);	// �̵� �ִϸ��̼� ����


        isWandering = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Down") || collision.gameObject.name.Contains("Up"))
        {
            speed_y = -speed_y;
        }
        else if (collision.gameObject.name.Contains("Left") || collision.gameObject.name.Contains("Right"))
        {
            speed_x = -speed_x;
        }
            
    }

    private void OnMouseDown()
    {
        isWalking = false;
        anim.SetBool("isWalk", false);
        anim.SetTrigger("doTouch");

        audioSource.PlayOneShot(audioSource.clip);
        UpdateStatData();

    }

    private void UpdateStatData()
    {
        
        
        // DataLoad 
        SaveData Data = SaveSystem.Load("StatDB");

        // happyPoint���� 
        if(Data.happypoint >= 100)
        {
            Data.happypoint = 100;
            BotheredStack++;
        }
        else
        {
            Data.happypoint += 1.0f;
        }
       
        bool isTired = isOverHappyPoint(BotheredStack);
        if (isTired)
        {
            Data.hp -= 30.0f;
            Data.happypoint -= 20.0f;
            if(Data.hp <  0 ) Data.hp = 0;

            BotheredStack = 0;
        }

        // xp���� 
        if(Data.hp <= 10)
        {
            Data.xp += 0.1f;
        }
        else
        {
            Data.xp += 50.0f;
        }

        // UI�� ���� �ݿ� 
        xpSlider.value = Data.xp;
        hpSlider.value = Data.hp;
        happyPointSlider.value = Data.happypoint;

        // Stat�ݿ� �ܼ� ��� 
        Debug.Log(Data.hp + " , " + Data.xp + " , " + Data.happypoint);
        Debug.Log(BotheredStack);
        // stat �ݿ�
        SaveSystem.Save(Data, "StatDB");

    }

    private bool isOverHappyPoint(int bothered) 
    {
        bool isTired = false;
        if(bothered >= 100.0f)
        {
            isTired = true;
        }

        return isTired;
    }



}
