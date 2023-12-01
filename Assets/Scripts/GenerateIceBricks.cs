using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    //�ش� CS�� ���� ȭ���� GameObject (�� ������Ʈ)�� �����ϰ� �ش� ������Ʈ�� ����. 
    public GameObject brick1; 
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4; // brick1~4���� ���� �ٸ� ����� ���� ����.
    private int[] Bricks; // brick1~4�� �����, brickID�� ������ �迭�� ���� ��, brickID�� ���� �ٸ� ����� �����ϵ��� �� ����.

    void BrickIDDistribution()
    {
        System.Random random = new System.Random();     // �׳� C#����ó�� Random random = new Random();���� �ߴ��� UnityEngine.Random���� System.Random���� �𸨴ϴ�.
        Bricks = new int[63];                 // Bricks��� �̸���, 63���� ������ ���� �迭 ����. ���� �ø��� �ʹٸ�, �� �κ��� �����ϸ� ��. �� ������ ���������� ���� �ٸ��� �ϰ� �ʹٸ�, ���� �ٸ� �̸��� �迭�� �ְ�, ������������ �ʿ��� �迭�� �ҷ����� ���� ������...
        for (int i = 0; i<63; i++)
        {
            Bricks[i] = random.Next(1, 5);           // Bricks[i]�� 1~4���� �����ϰ� ���� ����.
        }
    }
    void Start()
    {
        BrickIDDistribution();
        for (int i = 0; i< 63; i++) // ȭ�鿡 ǥ���� ���� �� : ���� �ӽ÷� ���� �ؽ��ķδ�, 9X7~8������ �̻����� ����. �ϴ��� 9X7 �迭�� ����
        {
            GameObject newBrick;   // newBrick?
            switch(Bricks[i])    // Bricks[i]�� 1~4���� ������ �ְ�, �� ���� ���� �ٸ� ������ Instantiate
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
                default:  // ��ǻ� ����Ʈ���� ������ �� ������ switch���������� �ʿ�. case1�� default������ ����.
                    newBrick = Instantiate(brick1);
                    break;
            }
            newBrick.transform.parent = GameObject.Find("Bricks").transform;   // GameObject Bricks�� �ڽ����� ������ ������ �������.

            float x = (i % 9) * 0.54f - 2.16f;    // ���� ������ �ִ� ��������Ʈ�� ���� ���� : �ش� ������ ��, ���� 9�� ��ġ ����
            float y = (i / 9) * 0.28f;                 // ���� ������ �ִ� ��������Ʈ�� ���� ���� : �ش� ������ ��, ���� 9���� ��ġ�Ǿ��� �� ���� ���� 63���̹Ƿ� 7�� ����.
            newBrick.transform.position = new Vector2(x, y);
        }
    }
}

// �ش� �ڵ��� �ƽ��� �� : Ȯ�强? - switch���� ����� �� ���Ͱ� �̹� Ȯ�强�� ���� �� �� ���ƿ�...
