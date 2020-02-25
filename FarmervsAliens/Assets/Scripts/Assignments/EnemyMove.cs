using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
     public GameObject player;
    //public Transform target; // transform.Translate example
     private Rigidbody enemyRb; // Velocity and Add Force examples
     public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        //target = GameObject.Find("Player").transform;// Transform.Translate example
    }

    // Update is called once per frame
    void Update()
    {

        // Transform.Translate            
            //transform.LookAt(target);
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        
    }

    void FixedUpdate(){
        // Change  Velocity
            //enemyRb.velocity = player * moveSpeed;
        // Add Force
            enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
       // MovePosition 
            //enemyRb.MovePosition((player.transform.position - transform.position).normalized * moveSpeed);     
    }
}
