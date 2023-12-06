using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallControl : MonoBehaviour
{
    public float ballSpeed = 8.0f;
    public Vector2 ballDirection; //공의 속도
    public bool isBallReleased = false;      //공이 패들에서 떨어졌는가 (붙어있음)
    public PaddleAnimationControl paddleAnimation;
    private DataHolder dataHolder;
    public Animator catAnimator;
    public Animator dogAnimator;

    //공의 방향
    // Start is called before the first frame update
    public void Start()
    {
        ballDirection = Vector2.up.normalized;      //처음 시작할때 공의 방향을 위쪽으로
        dataHolder = DataHolder.Instance;
    }
    // Update is called once per frame
    void Update()
    {
        if (!isBallReleased)
        {
            Vector3 paddlePosition = GameObject.Find("Paddle").transform.position;        ////패들 오브젝트의 위치를 찾아옴
            Vector3 ballPosition = paddlePosition;        ////공의 위치를 패들의 위치로 변경
            ballPosition.y -= 4f;                       //// 공과 패들사이 간격
            transform.position = ballPosition;            //// 공을 패들에 위치
            if (Input.GetButtonDown("Fire1")) //// 공 발사
            {
                isBallReleased = true;        ////공이 패들에서 떨어짐
                ballDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;         //// 위쪽 랜덤방향으로 공 발사(직각으로 발사할 경우 random.range를 빼고 좌표룰 설정해준다.
                AudioManager.instance.PlayBgm(true); // 게임시작할때 BGM을 틀어주는 함수인데 아직 START 함수가 따로 없어서 여기다 넣어뒀어요.
                AudioManager.instance.PlaySfx(AudioManager.Sfx.ShootSound); // ★공 발사 소리
            }
        }
        else
        {
            transform.Translate(ballDirection * ballSpeed * Time.deltaTime);        ////시간에 따른 공의 이동    방향*속도*시간
        }
    }
    public void OnCollisionEnter2D(Collision2D collision) //rigid2D나 coli2D가 다른 rigid2D나 coli2D에 부딪혔을때 실행
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Brick")) // 게임오브젝트 Wall 태그에 충돌
        {
            ballDirection = Vector2.Reflect(ballDirection, collision.contacts[0].normal);   // 벽에 충돌할때 방향 반전

            if (collision.gameObject.CompareTag("Wall"))
            {
                AudioManager.instance.PlaySfx(AudioManager.Sfx.Wall2Sound); //★벽에 부딪힐때 소리
            }
            else
            {
                AudioManager.instance.PlaySfx(AudioManager.Sfx.BreakSound);//★벽돌에 부딪힐때 소리
            }

            
        }
        else if (collision.gameObject.CompareTag("Paddle"))     //패들과 충돌할때 방향설정
        {
            float hitpoint = collision.contacts[0].point.x;     // 충돌 지점의 x좌표를 hitpoint에 저장
            float paddleCenter = collision.transform.position.x;        //패들의 중심 x좌표를 paddlecenter에 저장
            float angle = (hitpoint - paddleCenter) * 2.0f;         // 충돌점과 중심으로 각도 계산
            ballDirection = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)).normalized; // 각도를 기반으로 방향벡터를 만들고 normalized로 크기1로 만듦
            AudioManager.instance.PlaySfx(AudioManager.Sfx.Cat2Sound); //★패들과 공이 부딪힐때 냐옹~
        }

        if (collision.gameObject.CompareTag("BottomWall"))
        {
            BallRest();
            AudioManager.instance.PlaySfx(AudioManager.Sfx.DropSound);//★바닥에 떨어졌때 소리
            if (DataHolder.Instance.button1)
            {
                catAnimator.SetTrigger("IsBallDropCat");
            }
            else if (DataHolder.Instance.button2)
            {
                dogAnimator.SetTrigger("IsBallDropDog");
            }
        }

    }

    void BallRest()
    {
        GameManager.I.PlayerHP -= 1;
        isBallReleased = false;
    }
}