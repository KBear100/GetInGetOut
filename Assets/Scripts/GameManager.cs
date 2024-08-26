using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float roundLength = 30;
    [SerializeField] Spawner coinSpawner1;
    [SerializeField] Spawner coinSpawner2;
    [SerializeField] Spawner enemySpawner1;
    [SerializeField] Spawner enemySpawner2;

    float timer;

    void Start()
    {
        timer = roundLength;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            if(coinSpawner1.spawnTimer != 1.5f)
            {
                coinSpawner1.spawnTimer -= 0.5f;
                coinSpawner2.spawnTimer -= 0.5f;
                coinSpawner1.coin.GetComponent<Collectable>().timer -= 0.3f;
                coinSpawner2.coin.GetComponent<Collectable>().timer -= 0.3f;
            }
            if(enemySpawner1.spawnTimer != 2.0f)
            {
                enemySpawner1.spawnTimer -= 1;
                enemySpawner2.spawnTimer -= 1;
            }
            timer = roundLength;
        }
    }
}
