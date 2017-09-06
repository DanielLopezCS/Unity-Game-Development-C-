using UnityEngine;


public class EnemySpawner : MonoBehaviour {
    [SerializeField] private GameObject enemyWave1;
    [SerializeField] private GameObject powerUp;
    [SerializeField] private int powerUpThreshold;
    [SerializeField] private GameObject player;
    private int powerUpTimer = 0;
    public float unitTimer = .5f;
    private float counter = 0f;
 
	// Use this for initialization
	void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
        
        counter += Time.deltaTime;
       
        if (counter>= unitTimer)
        {
            if (powerUpTimer != powerUpThreshold)
            {
              
                Vector3 myX = new Vector3(Random.Range(-5f, 5f), 6, 0);
                Quaternion myQ = new Quaternion();
                Instantiate(enemyWave1, myX, myQ);
                counter = 0;
                powerUpTimer++;
            }
            else
            {
             
                powerUpTimer = 0;
                Vector3 myX = new Vector3(Random.Range(-5f, 5f), 6, 0);
                Quaternion myQ = new Quaternion();
                Instantiate(powerUp, myX, myQ).SendMessage("setPlayer", player);
                
                counter = 0;

            }
        }


	}
}
