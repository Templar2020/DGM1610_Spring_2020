using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Variables
    //Access Modifier - Type - Name ;
    public float speed;
    public float turnSpeed;
    public float verticalInput;
    public float horizontInput;

      

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Initalized input variables with input source values
        verticalInput = Input.GetAxis("Vertical");
        horizontInput = Input.GetAxis("Horizontal");

        // Moves the controller forward and backwards based on vertical input

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotates the controller left and right based on horizontal input

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontInput);

        
    }
}
