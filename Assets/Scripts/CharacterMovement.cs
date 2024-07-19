using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed = 3;

    Rigidbody2D rb;
    Vector2 vel = Vector2.zero;
    public int collectables = 0;

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
