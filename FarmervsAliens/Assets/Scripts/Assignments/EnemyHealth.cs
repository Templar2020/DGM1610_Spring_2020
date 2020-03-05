using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points = 10;

    void Start()
    {
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //Keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");
            // Add points to score for killing enemy
            //scoreManager.AddPoints(points);
            //Move enemy to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //Reset enemy Health
            currentHealth = maxHealth;
        }
    }
}
