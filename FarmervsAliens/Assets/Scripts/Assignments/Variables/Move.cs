using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
    }

    // Detect collison with another object
    void OnCollisionEnter(Collision other){

    }

    void OnTriggerEnter(Collider other){

    }

}
