﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Game Score: " + score);

    }
}
