using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    //해당 CS는 메인 화면의 GameObject (빈 오브젝트)를 생성하고 해당 오브젝트에 붙임. 
    public GameObject brick1; 
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4; // brick1~4에는 각기 다른 모양의 블럭을 씌움.
    private int[] Bricks; // brick1~4를 만들고, brickID를 랜덤한 배열로 만든 후, brickID에 따라 다른 블록을 생성하도록 할 예정.

    void BrickIDDistribution()
    {
        System.Random random = new System.Random();     // 그냥 C#에서처럼 Random random = new Random();으로 했더니 UnityEngine.Random인지 System.Random인지 모릅니다.
        Bricks = new int[63];                 // Bricks라는 이름의, 63개의 변수를 갖는 배열 생성. 블럭을 늘리고 싶다면, 이 부분을 수정하면 됨. 블럭 개수를 스테이지에 따라 다르게 하고 싶다면, 서로 다른 이름의 배열을 주고, 스테이지에서 필요한 배열을 불러오면 되지 않을까...
        for (int i = 0; i<63; i++)
        {
            Bricks[i] = random.Next(1, 5);           // Bricks[i]에 1~4까지 랜덤하게 값을 배정.
        }
    }
    void Start()
    {
        BrickIDDistribution();
        for (int i = 0; i< 63; i++) // 화면에 표시할 블럭의 수 : 오늘 임시로 만들어본 텍스쳐로는, 9X7~8정도가 이상적일 듯함. 일단은 9X7 배열을 상정
        {
            GameObject newBrick;   // newBrick?
            switch(Bricks[i])    // Bricks[i]가 1~4값을 가지고 있고, 이 값에 따라 다른 벽돌을 Instantiate
            {
                case 2:
                    newBrick = Instantiate(brick2);
                    break;
                case 3:
                    newBrick = Instantiate(brick3);
                    break;
                case 4:
                    newBrick = Instantiate(brick4);
                    break;
                default:  // 사실상 디폴트값이 존재할 수 없으나 switch구문때문에 필요. case1을 default값으로 돌림.
                    newBrick = Instantiate(brick1);
                    break;
            }
            newBrick.transform.parent = GameObject.Find("Bricks").transform;   // GameObject Bricks의 자식으로 복제한 블럭들을 집어넣음.

            float x = (i % 9) * 0.54f - 2.16f;    // 지금 가지고 있는 스프라이트상 가로 간격 : 해당 계산식일 때, 가로 9개 배치 가능
            float y = (i / 9) * 0.28f;                 // 지금 가지고 있는 스프라이트상 세로 간격 : 해당 계산식일 때, 가로 9개가 배치되었고 총 벽돌 수는 63개이므로 7줄 생성.
            newBrick.transform.position = new Vector2(x, y);
        }
    }
}

// 해당 코드의 아쉬운 점 : 확장성? - switch문을 사용한 것 부터가 이미 확장성은 개나 준 것 같아요...
