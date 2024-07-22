using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3;

    [HideInInspector] public int collectables = 0;
    [HideInInspector] public int health = 100;

    Rigidbody2D rb;
    Vector2 vel = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vel.x = Input.GetAxis("Horizontal");
        vel.y = Input.GetAxis("Vertical");

        rb.velocity = vel * speed;
    }
}
