using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        if (Input.GetKeyDown("s"))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
    }
}
