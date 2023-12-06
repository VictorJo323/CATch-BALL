using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            Debug.Log("게임 오버다");
            BallRest();
        }

    }

    void BallRest()
    {
        GameManager.I.PlayerHP -= 3;
        BallControl.isBallReleased = false;
    }

}
