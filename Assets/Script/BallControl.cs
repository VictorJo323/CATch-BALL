using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float ballspeed = 8.0f;          //���� �ӵ�
    public bool isBallReleased = false;      //���� �е鿡�� �������°� (�پ�����)

    public Vector2 ballDirection;           //���� ����
    // Start is called before the first frame update
    void Start()
    {
        ballDirection = Vector2.up.normalized;      //ó�� �����Ҷ� ���� ������ ��������
    }

    // Update is called once per frame
    void Update()
    {
        //if (isballreleased)
        //{
        //    vector3 paddleposition = gameobject.find("paddle").transform.position;        ////�е� ������Ʈ�� ��ġ�� ã�ƿ�

        //    vector3 ballposition = paddleposition;        ////���� ��ġ�� �е��� ��ġ�� ����
        //    ballposition.y += 0.1f;                       //// ���� �е���� ����
        //    transform.position = ballposition;            //// ���� �е鿡 ��ġ

        //    if (input.getbuttondown("fire")) //// �� �߻�
        //    {
        //        isballreleased = true;        ////���� �е鿡�� ������

        //        balldirection = new vector2(random.range(-1f, 1f), 1).normalized;         //// ���� ������������ �� �߻�(�������� �߻��� ��� random.range�� ���� ��ǥ�� �������ش�.
        //    }
        //}
        //else
        //{
        //    transform.position = (balldirection * ballspeed * time.deltatime);        ////�ð��� ���� ���� �̵�    ����*�ӵ�*�ð�
        //}

        void OnCollisionEnter2D(Collision2D collision) //rigid2D�� coli2D�� �ٸ� rigid2D�� coli2D�� �ε������� ����
        {
            if (collision.gameObject.CompareTag("Wall")) // ���ӿ�����Ʈ Wall �±׿� �浹
            {
                ballDirection = Vector2.Reflect(ballDirection, collision.contacts[0].normal);   // ���� �浹�Ҷ� ���� ����
            }
            else if (collision.gameObject.CompareTag("Paddle"))     //�е�� �浹�Ҷ� ���⼳��
            {
                float hitpoint = collision.contacts[0].point.x;     // �浹 ������ x��ǥ�� hitpoint�� ����
                float paddleCenter = collision.transform.position.x;        //�е��� �߽� x��ǥ�� paddlecenter�� ����
                float angle = (hitpoint - paddleCenter) * 2.0f;         // �浹���� �߽����� ���� ���
                ballDirection = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)).normalized; // ������ ������� ���⺤�͸� ����� normalized�� ũ��1�� ���� 
            }
        }
    }
}
