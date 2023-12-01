using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePaddleController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }


    // Update is called once per frame
    void LateUpdate()
    {
        
    }
}
