using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallControl : MonoBehaviour
{
    public float ballSpeed = 8.0f;

    public Vector2 ballDirection; //���� �ӵ�
    public bool isBallReleased = false;      //���� �е鿡�� �������°� (�پ�����)

    //���� ����
    // Start is called before the first frame update
    void Start()
    {
        ballDirection = Vector2.up.normalized;      //ó�� �����Ҷ� ���� ������ ��������
    }

    // Update is called once per frame
    void Update()
    {


        if (!isBallReleased)
        {
            Vector3 paddlePosition = GameObject.Find("Paddle").transform.position;        ////�е� ������Ʈ�� ��ġ�� ã�ƿ�

            Vector3 ballPosition = paddlePosition;        ////���� ��ġ�� �е��� ��ġ�� ����
            ballPosition.y -= 4;
            transform.position = ballPosition;            //// ���� �е鿡 ��ġ

            if (Input.GetButtonDown("Fire1")) //// �� �߻�
            {
                isBallReleased = true;        ////���� �е鿡�� ������

                ballDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;         //// ���� ������������ �� �߻�(�������� �߻��� ��� random.range�� ���� ��ǥ�� �������ش�.
            }
        }
        else
        {
            transform.Translate(ballDirection * ballSpeed * Time.deltaTime);        ////�ð��� ���� ���� �̵�    ����*�ӵ�*�ð�
        }

        if (gameObject.transform.position.y<=-5)
        {
            Debug.Log("�ƾ�");
            Invoke("BallReleased", 0.5f);
        }




    }
    private void OnCollisionEnter2D(Collision2D collision) //rigid2D�� coli2D�� �ٸ� rigid2D�� coli2D�� �ε������� ����
    {
        if (collision.gameObject.CompareTag("Wall")|| collision.gameObject.CompareTag("Brick")) // ���ӿ�����Ʈ Wall �±׿� �浹
        {
            ballDirection = Vector2.Reflect(ballDirection, collision.contacts[0].normal);   // ���� �浹�Ҷ� ���� ����
        }

        if (collision.gameObject.CompareTag("Paddle"))     //�е�� �浹�Ҷ� ���⼳��
        {
            float hitpoint = collision.contacts[0].point.x;     // �浹 ������ x��ǥ�� hitpoint�� ����
            float paddleCenter = collision.transform.position.x;        //�е��� �߽� x��ǥ�� paddlecenter�� ����
            float angle = (hitpoint - paddleCenter) * 2.0f;         // �浹���� �߽����� ���� ���
            ballDirection = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)).normalized; // ������ ������� ���⺤�͸� ����� normalized�� ũ��1�� ���� 
        }


        if (collision.gameObject.CompareTag("Brick"))
        {
            Debug.Log("�ε�����!");
            Destroy(collision.gameObject);
        }
    }

    private void BallReleased()
    {
        isBallReleased = false;
        if (GameManager.I.PlayerHP <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
        GameManager.I.PlayerHP -= 1;
    }
}
