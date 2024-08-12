using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float timer = 5;

    void Start()
    {


    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0 ) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyMovement>().health -= 10;
        }

        if(collision.tag != "Player") Destroy(gameObject);
    }
}
