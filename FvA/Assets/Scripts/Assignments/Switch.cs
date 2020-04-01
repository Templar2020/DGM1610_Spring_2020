using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string favHero = "Batman";
    public int smarts = 5;

    // Start is called before the first frame update
    void Start()
    {
        if(favHero == "Superman"){
            print("Wrong! Hes old news");
        }
        else if(favHero == "Thor"){
            print("Correct!");
        }
        else{
            print("Thats not a super hero");
        }
    }

        
    

    // Update is called once per frame
    void Update()
    {
        /*switch(favHero){

            case "Superman":
            print("Wrong!");
            break;

            case "Thor":
            print("Correct!");
            break;
             

        } */

        switch(smarts){
            case 1:
                print("your dumb!");
            break;
            case 5:
                print("your smart!");
            break;
            default: 
                print("Derp!");
            break;
        }
    }
}
