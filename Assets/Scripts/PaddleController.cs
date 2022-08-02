using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey; 
    public KeyCode downKey;
    public float speed = 1f;
    public float grownDuration = 5f;
    public float speedUpDuration = 5f;
    private Vector2 movement;
    private Rigidbody2D rb;
    private bool isGrown = false;
    private bool isSpeedUp = false;
    private float grownTimer;
    private float growMultiplier;
    private float speedUpTimer;
    private float speedUpMultiplier;

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
        HandleGrown();
        HandleSpeedUp();
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
        Debug.Log("TEST: " + movement);
        rb.velocity = movement;
    }

    private void HandleGrown()
    {
        if (isGrown)
        {
            grownTimer += Time.deltaTime;
        }

        if (grownTimer >= grownDuration)
        {
            DeactivateGrow();
        }
    }

    private void HandleSpeedUp()
    {
        if (isSpeedUp)
        {
            speedUpTimer += Time.deltaTime;
        }

        if (speedUpTimer >= speedUpDuration)
        {
            DeactivateSpeedUp();
        }
    }

    public void ActivateGrow(float multiplier)
    {
        grownTimer = 0f;
        if (isGrown)
        {
            return;
        }
        isGrown = true;
        growMultiplier = multiplier;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * growMultiplier);
    }

    public void DeactivateGrow()
    {
        isGrown = false;
        grownTimer = 0f;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / growMultiplier);
    }

    public void ActivateSpeedUp(float multiplier)
    {
        speedUpTimer = 0f;
        if (isSpeedUp)
        {
            return;
        }
        isSpeedUp = true;
        speedUpMultiplier = multiplier;
        speed *= speedUpMultiplier;
    }

    public void DeactivateSpeedUp()
    {
        isSpeedUp = false;
        speedUpTimer = 0f;
        speed /= speedUpMultiplier;
    }
}
