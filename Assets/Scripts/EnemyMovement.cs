using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;
    [SerializeField] float speed;

    float vel;

    void Start()
    {
        
    }

    void Update()
    {
        vel = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, characterMovement.transform.position, vel);
    }
}
