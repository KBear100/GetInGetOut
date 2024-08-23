using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    [SerializeField] float displayWinScreenTimer = 3;

    bool exited = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(exited)
        {
            displayWinScreenTimer -= Time.deltaTime;
            if(displayWinScreenTimer < 0 )
            {
                SceneManager.LoadSceneAsync("Title", LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") winScreen.SetActive(true);
        exited = true;
    }
}
