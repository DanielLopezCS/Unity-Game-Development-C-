using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopWall : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.GetType());
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Bullet")
        {
        Destroy(collider.gameObject);

        }
    }
}