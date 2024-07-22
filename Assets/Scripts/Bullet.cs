using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;

    [HideInInspector] public Vector2 target = Vector2.zero;
    float vel;

    void Start()
    {
        
    }

    void Update()
    {
        vel = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, vel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyMovement>().health -= 10;
        }
    }
}
