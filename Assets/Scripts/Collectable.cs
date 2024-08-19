using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public float timer;

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
        if(collision.tag == "Player")
        {
            var character = collision.GetComponent<Player>().collectables++;
            
            Destroy(this.gameObject);
        }
    }
}
