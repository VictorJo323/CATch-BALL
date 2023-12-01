using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
    bool _ShotBall = false;
    MoveBall _moveball;

    private void Awake()
    {
        _moveball = GetComponent<MoveBall>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) _moveball.MoveBalll();
    }
}
