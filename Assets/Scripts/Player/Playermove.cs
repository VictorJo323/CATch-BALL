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

            // y 좌표는 그대로 유지하여 메인 카메라 안에서 이동
            mousePosition.y = transform.position.y;
            mousePosition.z = transform.position.z;

            // 메인 카메라의 시야 겅계 가져오기
            float cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;

            // x 좌표를 메인 카메라의 시야 경계로만큼 제한
            mousePosition.x = Mathf.Clamp(mousePosition.x, -cameraHalfWidth, cameraHalfWidth);

            // 마우스 커서 따라가기
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
    
    // 클릭한 지점으로 패들이 이동할때의 코드



