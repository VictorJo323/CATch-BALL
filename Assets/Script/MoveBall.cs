using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] float speed = 100f;
    public Rigidbody2D rb;
    float x, y;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) MoveBalll();
    }

    public void MoveBalll()
    {
        x = 0;
        y = 1;
        Vector2 dir = new Vector2(x, y).normalized;

        rb.AddForce(dir * speed);
    }
}
