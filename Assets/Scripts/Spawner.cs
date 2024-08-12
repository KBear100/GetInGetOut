using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] float spawnTimer;
    [Header("Coords")]
    [SerializeField] float xMin;
    [SerializeField] float xMax;
    [SerializeField] float yMin;
    [SerializeField] float yMax;

    float timer;
    Vector2 pos;

    void Start()
    {
        timer = spawnTimer;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0 )
        {
            pos.x = Random.Range(xMin, xMax );
            pos.y = Random.Range(yMin, yMax );
            coin.transform.position = pos;
            Instantiate( coin );
            timer = spawnTimer;
        }
    }
}
