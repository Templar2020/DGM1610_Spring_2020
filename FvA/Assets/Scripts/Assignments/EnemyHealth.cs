using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public const int maxHealth = 3;

    public Transform spawnPoint;

    public int points;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount){
        currentHealth -= amount;

        if(currentHealth <= 0){
            // Keep score at zero
            currentHealth = 0;
            //Add points for killing the enemy
            ScoreManager.AddPoints(points);
            //Respawn Enemy at spawn point
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //Reset the enemies health
            currentHealth = maxHealth;

        }
    }      
}
