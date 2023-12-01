using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float ballspeed = 8.0f;          //공의 속도
    public bool isBallReleased = false;      //공이 패들에서 떨어졌는가 (붙어있음)

    public Vector2 ballDirection;           //공의 방향
    // Start is called before the first frame update
    void Start()
    {
        ballDirection = Vector2.up.normalized;      //처음 시작할때 공의 방향을 위쪽으로
    }

    // Update is called once per frame
    void Update()
    {
        //if (isballreleased)
        //{
        //    vector3 paddleposition = gameobject.find("paddle").transform.position;        ////패들 오브젝트의 위치를 찾아옴

        //    vector3 ballposition = paddleposition;        ////공의 위치를 패들의 위치로 변경
        //    ballposition.y += 0.1f;                       //// 공과 패들사이 간격
        //    transform.position = ballposition;            //// 공을 패들에 위치

        //    if (input.getbuttondown("fire")) //// 공 발사
        //    {
        //        isballreleased = true;        ////공이 패들에서 떨어짐

        //        balldirection = new vector2(random.range(-1f, 1f), 1).normalized;         //// 위쪽 랜덤방향으로 공 발사(직각으로 발사할 경우 random.range를 빼고 좌표룰 설정해준다.
        //    }
        //}
        //else
        //{
        //    transform.position = (balldirection * ballspeed * time.deltatime);        ////시간에 따른 공의 이동    방향*속도*시간
        //}

        void OnCollisionEnter2D(Collision2D collision) //rigid2D나 coli2D가 다른 rigid2D나 coli2D에 부딪혔을때 실행
        {
            if (collision.gameObject.CompareTag("Wall")) // 게임오브젝트 Wall 태그에 충돌
            {
                ballDirection = Vector2.Reflect(ballDirection, collision.contacts[0].normal);   // 벽에 충돌할때 방향 반전
            }
            else if (collision.gameObject.CompareTag("Paddle"))     //패들과 충돌할때 방향설정
            {
                float hitpoint = collision.contacts[0].point.x;     // 충돌 지점의 x좌표를 hitpoint에 저장
                float paddleCenter = collision.transform.position.x;        //패들의 중심 x좌표를 paddlecenter에 저장
                float angle = (hitpoint - paddleCenter) * 2.0f;         // 충돌점과 중심으로 각도 계산
                ballDirection = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)).normalized; // 각도를 기반으로 방향벡터를 만들고 normalized로 크기1로 만듦 
            }
        }
    }
}
