using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 //This following line of code adds our Scriptable Object as an option in the Asset menu. 
[CreateAssetMenu(fileName="New SO", menuName="Scriptable Objects/New Object")]

public class SO : ScriptableObject // Notice how we change the inheritance from MonoBehavior to SciptableObject
{
   
    //Scriptable Objects like Mono scripts can contain variables.

    public string fullName;
    public string description;

   public GameObject model;

   public Color color;

    //Scriptable Objects do not use monobehavior callbacks such as Start() and Update().

    //Scriptable objects can also contain functions and conditionals.

    /* private void PrintOut(string name, string description){
        Debug.Log(name + " "+ description);
        if(name == "Chuck Norris"){
            Debug.Log("Chuck Norris allows this program to run!");
        }
    }     */
   
}
