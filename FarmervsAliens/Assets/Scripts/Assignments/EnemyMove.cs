using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public int damage;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
