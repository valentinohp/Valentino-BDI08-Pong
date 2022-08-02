using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int maxPowerUpAmount; 
    public float spawnInterval;
    public List<GameObject> powerUpTemplateList;
    public Transform boundaryMin;
    public Transform boundaryMax;
    private List<GameObject> powerUpList; 
    private float timer;
     
    private void Start() 
    { 
        powerUpList = new List<GameObject>();
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer = 0;
        }
    }

    public void GenerateRandomPowerUp()
    {
        Vector2 randomPosition = new Vector2(Random.Range(boundaryMin.position.x, boundaryMax.position.x), Random.Range(boundaryMin.position.y, boundaryMax.position.y));
        GenerateRandomPowerUp(randomPosition);
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount) 
        { 
            return; 
        }
 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], position, Quaternion.identity); 
        powerUp.SetActive(true); 
 
        powerUpList.Add(powerUp); 
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
