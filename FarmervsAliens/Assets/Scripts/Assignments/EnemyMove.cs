using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 target; // transform.Translate example
    private Rigidbody enemyRb; // Velocity and Add Force examples
     public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Transform.Translate
            target = GameObject.Find("Player");
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        
    }

    void FixedUpdate(){
        // Change  Velocity
            //enemyRb.Velocity = player * moveSpeed;
        // Add Force
            //enemyRb.AddForce((player.transform.position - transform.position).normalize * moveSpeed);
       // MovePosition 
            //enemyRb.MovePosition((player.transform.position - transform.position).normalize * moveSpeed);     
    }
}
