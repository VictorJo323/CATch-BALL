using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float cursorSpeed = 9f;

    void Start()
    {
        
    }

    void Update()
    {
        
        

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // y ��ǥ�� �״�� �����Ͽ� ���� ī�޶� �ȿ��� �̵�
            mousePosition.y = transform.position.y;
            mousePosition.z = transform.position.z;

            // ���� ī�޶��� �þ� �ϰ� ��������
            float cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;

            // x ��ǥ�� ���� ī�޶��� �þ� ���θ�ŭ ����
            mousePosition.x = Mathf.Clamp(mousePosition.x, -cameraHalfWidth, cameraHalfWidth);

            // ���콺 Ŀ�� ���󰡱�
            transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * cursorSpeed);
    }
    
}


    /* Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            CallTargetPos();

        MoveToTarget();

    }

    private void CallTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, 0, 0);
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }*/
    
    // Ŭ���� �������� �е��� �̵��Ҷ��� �ڵ�



