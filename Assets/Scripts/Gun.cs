using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Rigidbody2D bullet;
    [SerializeField] float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Transform cam = Camera.main.transform;
            Vector2 localMousePos = cam.InverseTransformPoint(worldMousePos);
            Rigidbody2D bulletCopy = Instantiate(bullet, transform.position, transform.rotation);
            bulletCopy.AddForce(localMousePos.normalized * speed);
        }
    }
}
