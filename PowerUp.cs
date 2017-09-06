using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
    private GameObject myPlayer;
 
    // Use this for initialization
    void Start () {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -.5f);
    }
	public void setPlayer(GameObject player)
    {
        myPlayer = player;
    }
	// Update is called once per frame
	void Update () {
		
	}

   void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bullet")
        {
            myPlayer.SendMessage("doubleSpeed");
            Destroy(collider.gameObject);
            Destroy(gameObject);
          
        }
    }
}
