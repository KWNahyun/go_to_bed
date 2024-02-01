using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCat : MonoBehaviour
{
    public int move_delay;	// 다음 이동까지의 딜레이 시간
    public int move_time;	// 이동 시간

    float speed_x;	// x축 방향 이동 속도
    float speed_y;	// y축 방향 이동 속도
    bool isWandering;
    public static bool isWalking;

    SpriteRenderer sprite;
    Animator anim;


    [SerializeField] private Slider xpSlider;
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Slider happyPointSlider;

    //사운드 모듈
    public AudioClip audioPop;
    AudioSource audioSource;

    void Awake()
    {
        Time.timeScale = 1; // 미니게임에서 강제 종료했을때 모든 코드가 멈춰 버리는 문제해결 
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        isWandering = false;
        isWalking = false;
    }


    void FixedUpdate()
    {
        if (!isWandering)
            StartCoroutine(Wander());	// 코루틴 실행
        
        if (isWalking)
            Move();
    }


    void Move()
    {
        if (speed_x != 0)
            sprite.flipX = speed_x < 0; // x축 속도에 따라 Spite 이미지를 뒤집음

        transform.Translate(speed_x, speed_y, speed_y);	// 젤리 이동
    }


    IEnumerator Wander()
    {
        move_delay = 2;
        move_time = 3;

        // Translate로 이동할 시 Object가 텔레포트 하는 것을 방지하기 위해 Time.deltaTime을 곱해줌
        speed_x = Random.Range(-1.8f, 1.8f) * Time.deltaTime;
        speed_y = Random.Range(-1.8f, 1.8f) * Time.deltaTime;

        isWandering = true;

        yield return new WaitForSeconds(move_delay);

        isWalking = true;
        anim.SetBool("isWalk", true);	// 이동 애니메이션 실행

        yield return new WaitForSeconds(move_time);

        isWalking = false;
        anim.SetBool("isWalk", false);	// 이동 애니메이션 종료


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
    }

    private void UpdateStatData()
    {
        // DataLoad 



        // happyPoint증가 


        // hp증가 


        // xp증가
         

    }



}
