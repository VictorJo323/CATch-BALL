using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAnimationControl : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("ƨ���");
            animator.SetTrigger("IsBallHit");
        }

        if (collision.gameObject.tag == "Item")
        {
            Debug.Log("�Ծ���");
            animator.SetTrigger("IsItemTaken");
        }

    }
}
