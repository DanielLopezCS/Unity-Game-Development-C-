using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    private Rigidbody2D bulletRigid;
    // Use this for initialization
    void Start () {
        bulletRigid = this.GetComponent<Rigidbody2D>();
        bulletRigid.velocity = new Vector2(0, 5f);
    }
	

	// Update is called once per frame
	void Update () {
        
	}
    public void fireBullet()
    {
     
    }

}
