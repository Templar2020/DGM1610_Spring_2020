using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;

    public GameObject projectilePrefab;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position , projectilePrefab.transform.rotation);
        }

                        //  ( x, y, z)
    }

    // Detect collison with another object
    /* void OnCollisionEnter(Collision other){
       

        if (other.gameObject.CompareTag("Floor"))//Primary
        {
            Debug.Log("Colliding with Floor");
        }
        else if(other.gameObject.CompareTag("Obstacle"))// Secondary
        {
            Debug.Log("Colliding with Obstacle");
        }
        else // Default
        {
            Debug.Log("...");
        }

    }

    void OnTriggerEnter(Collider other){
        Debug.Log("You have entered the trigger!");
    }
*/
}
