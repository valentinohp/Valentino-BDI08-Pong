using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetBall()
    {
        transform.position = resetPosition;
    }

    public void ActivateSpeedUp(float multiplier)
    {
        rb.velocity *= multiplier;
    }
}
