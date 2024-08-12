using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] float speed;
    [SerializeField] public int health;

    float vel;
    bool faceRight = true;
    Vector2 prevFrame;

    private void Awake()
    {
        player = FindAnyObjectByType(typeof(Player)).GetComponent<Player>();
    }

    void Start()
    {
        prevFrame = transform.position;
    }

    void Update()
    {
        vel = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, vel);

        Vector2 currentFrame = transform.position;

        float dir = currentFrame.x - prevFrame.x;

        if (dir > 0 && !faceRight)
        {
            transform.localScale = new Vector3(1, 1, 1);
            faceRight = true;
        }
        if (dir < 0 && faceRight)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            faceRight = false;
        }

        if (health <= 0) Destroy(gameObject);

        prevFrame = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.health -= 10;
        }
    }
}
