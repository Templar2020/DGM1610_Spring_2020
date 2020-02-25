using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float xSpawnRange;
    public float zSpawnPos;
    public float spawnInterval;
    public float startDelay;
    public int enemyIndex;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnRandomEnemy();
        } 
    }

    void SpawnRandomEnemy(){
        Vector3 spawnpos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);

         int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIndex], spawnpos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
