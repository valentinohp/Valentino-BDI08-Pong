using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
{
    public Collider2D ball; 
    public float multiplier; 
    public PowerUpManager manager;
    public float powerUpLife;
    private float timer;

    private void Start() 
    {
        timer = 0f;    
    }

    private void Update() 
    {
        timer += Time.deltaTime;
        if (timer >= powerUpLife)
        {
            manager.RemovePowerUp(gameObject);
            timer = 0f;
        }    
    }
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        { 
            ball.GetComponent<BallController>().ActivateSpeedUp(multiplier); 
            manager.RemovePowerUp(gameObject);
        }     
    }
}
