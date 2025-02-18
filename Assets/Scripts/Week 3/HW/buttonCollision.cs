using UnityEngine;

public class buttonCollision : MonoBehaviour
{
    public GameObject runningball1;
    public GameObject runningBallSpawnPoint;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {

        if(otherObject.gameObject.tag == "button")
        {
           runningball1.GetComponent<MeshRenderer>().material.color = Color.red;
           
           GameObject go = Instantiate(runningball1, runningBallSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}
