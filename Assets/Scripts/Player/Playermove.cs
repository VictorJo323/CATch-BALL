using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    //[SerializeField] float speed = 1f;
    Vector3 mousePos, transPos, targetPos;

    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {

    }

    void Update()
    {
        if (Time.timeScale != 0)
        {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x >= 2.8)
            {
                mousePos.x = 2.8f;
            }

            else if (mousePos.x <= -2.8)
            {
                mousePos.x = -2.8f;
            }

            transform.position = new Vector3(mousePos.x, 0, 0);
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
    
    // 클릭한 지점으로 패들이 이동할때의 코드


}
