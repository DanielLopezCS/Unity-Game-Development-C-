using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject myPlayer;

    public GameObject bullet;

    // Use this for initialization
    void Start () {
        

        Instantiate(bullet, myPlayer.transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
