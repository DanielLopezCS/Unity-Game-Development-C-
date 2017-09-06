using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Rigidbody2D myRigid;
   



    private GameObject s;
    private List<GameObject> myNodes;
   
 
    private Rigidbody2D cubeRigid;
    // Use this for initialization

    public GameObject bullet;
    private Rigidbody bulletBody;
    private bool start = false;
    public float bulletSpeed = 10f;
    private bool isAlive = true;
    GameObject testBullet;

    private float bulletThreshold = .15f;
    private float currentCount = 0f;
    public float minX = -5f;
    public float maxX = 5f;

    [SerializeField] private KeyCode moveLeft;
    [SerializeField] private KeyCode moveRight;

    [SerializeField] private GameObject myObject;


    public void doubleSpeed()
    {
        if (bulletThreshold >= .05f)
        {
            bulletThreshold *= .8f;
            
        }
       
    }
    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        float mousePosInBlocks = (Input.mousePosition.x / Screen.width) * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        this.transform.position = paddlePos;
      
    }

    void Start () {

        myNodes = new List<GameObject>();
       

    }
	
	// Update is called once per frame
	void Update () {

        currentCount += Time.deltaTime;
        if(currentCount >= bulletThreshold)
        {
            /* 
            These 3 Statements Will Make It So The Bullets Stay In The X Position It Was Originally Launched At. I believe the 
            laser-like bullet shooting looks cleaner so I chose to keep it that way. (Must delete the other Instantiate statement)

            Vector3 playerVector = new Vector3(transform.position.x, transform.position.y, 0);
            Quaternion myQ = new Quaternion();
            Instantiate(bullet, playerVector, myQ);

            */

            currentCount = 0;
            Instantiate(bullet, transform);
          
        }
       // MoveWithMouse();

        if(Input.GetKey(moveLeft))
        {
          
            //this.transform.position = new Vector2(transform.position.x + 5f, 0);
           
            transform.Translate( Vector2.left * 4f * Time.deltaTime , null);
        }
        if (Input.GetKey(moveRight))
        {
         
            //this.transform.position = new Vector2(transform.position.x + 5f, 0);

            transform.Translate(Vector2.right * 4f * Time.deltaTime, null);
        }
    }

    void shootGun()
    {
      
        /*for (int i = 0; i < myNodes.Count; i++)
        {
            myNodes[i].GetComponent<Rigidbody>().velocity = new Vector3(0, bulletSpeed, 0);
                
        
        }
        */

    }
}
