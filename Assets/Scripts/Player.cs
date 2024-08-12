using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] GameObject loseScreen;

    [HideInInspector] public int collectables = 0;
    [HideInInspector] public int health = 100;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Vector2 vel = Vector2.zero;
    bool acceptInput = true;
    bool faceRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        vel.x = Input.GetAxis("Horizontal");
        vel.y = Input.GetAxis("Vertical");
        if(!acceptInput)
        {
            vel = Vector2.zero;
            animator.SetFloat("Speed", 0);
        }

        if (vel.x == 0 && vel.y == 0) animator.SetFloat("Speed", 0);
        else animator.SetFloat("Speed", 1);

        if(vel.x > 0 && !faceRight)
        {
            spriteRenderer.flipX = false;
            faceRight = true;
        }
        if(vel.x < 0 && faceRight)
        {
            spriteRenderer.flipX = true;
            faceRight = false;
        }

        rb.velocity = vel * speed;

        if(health <= 0)
        {
            loseScreen.SetActive(true);
            acceptInput = false;
        }
    }
}
