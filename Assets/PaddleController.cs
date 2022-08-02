using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey; 
    public KeyCode downKey;
    public float speed = 1f;
    private Vector2 movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
    }

    private void GetInput()
    {
        if (Input.GetKey(upKey))
        {
            movement = Vector2.up * speed;
            return;
        }

        if (Input.GetKey(downKey))
        {
            movement = Vector2.down * speed;
            return;
        }

        movement = Vector2.zero;
    }

    private void Move()
    {
        rb.velocity = movement;
    }
}
