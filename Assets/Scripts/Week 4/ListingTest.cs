using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AllCannonBalls : MonoBehaviour
{
  //public CannonBall cannonBall;

    public List<CannonBall> cannonballs = new List<CannonBall>();

    public GameObject cannonballPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannonballs= FindObjectsByType<CannonBall>(FindObjectsSortMode.None).ToList();
        //this one finds game objects by tag rather than funtion and returns it as an array of gameobjects you can convert to a list
      //GameObject.FindGameObjectsWithTag("cannonBall").ToList();
      
        //this one finds all objects with a specific script (Cannonball) and converts them to a list
        GameObject go = Instantiate(cannonballPrefab);
        cannonballs.Add(go.GetComponent<CannonBall>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //foreach will loop through each object in a list and allow you do to the saem action for every single instance in that list
            foreach(CannonBall ball in cannonballs)
            {
                ball.addrandomForce();

            }
        }

        if(Input.GetKeyDown(KeyCode.G))
            {
            int randomBall = Random.Range(0,cannonballs.Count);

            cannonballs[randomBall].addrandomForce();


        }
    }
}
