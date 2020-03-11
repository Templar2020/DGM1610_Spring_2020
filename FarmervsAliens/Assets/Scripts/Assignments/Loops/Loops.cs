using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //This variable is used with the For loop example
    //public int numEnemies = 5;
    //This variable is used with the While loop example
    //public int cupsInTheSink = 10;



    // Start is called before the first frame update
    void Start()
    {
        //For Loop Example
        /*for (int i = 0; i <= numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }*/

        //While Loop Example
      /* while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }*/

        //Do While Loop Example
       /*bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);*/

        //Foreach Loop Example
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
    }
    
}
