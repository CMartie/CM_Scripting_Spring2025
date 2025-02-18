using UnityEngine;

public class spawnBall : MonoBehaviour
{
    public GameObject runningBall;
    public GameObject runningBallSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ballSpawner();

    }

    public void ballSpawner()
    {
        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I am working");
           Instantiate(runningBall, runningBallSpawn.transform.position, Quaternion.identity);
        }
    }


        
    
}
