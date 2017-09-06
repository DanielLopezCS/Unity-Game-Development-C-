using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSphere : MonoBehaviour {
    public int health = 30;
    public float sphereSpeed = -.5f;
    private Rigidbody2D sphereRigid;
	// Use this for initialization
	void Start () {
        sphereRigid = GetComponent<Rigidbody2D>();
        sphereRigid.velocity = new Vector2(0, sphereSpeed);
	}
	
	// Update is called once per frame
	void Update () {
        sphereSpeed -= Time.deltaTime/7;
        sphereRigid.velocity = new Vector2(0, sphereSpeed);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bullet")
        {
            Destroy(collider.gameObject);

        }
        print("YOU HIT ME");
        health -= 5;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
