using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] float speed;
    [SerializeField] public int health;

    float vel;

    void Start()
    {
        
    }

    void Update()
    {
        vel = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, vel);

        if(health <= 0) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.health -= 10;
        }
    }
}
