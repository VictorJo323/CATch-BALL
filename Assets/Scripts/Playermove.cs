using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Vector3 mousePos, transPos, targetPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) CallTargetPos();
        MoveToTarget();

    }

    private void CallTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        if(transPos.x < -1.9f)
        {
            transPos.x = -1.9f;
        }
        else if(transPos.x > 1.9f)
        {
            transPos.x = 1.9f;
        }
        targetPos = new Vector3(transPos.x, 0, 0);
    }
    
    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }
}
