using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public int time = 3;


    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other){

        var health = other.gameObject.GetComponent<EnemyHealth>();

        if(health != null){
            health.TakeDamage(damage);
        }

    }
    
    IEnumerator DestroyBullet(){
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
       
    }
}
