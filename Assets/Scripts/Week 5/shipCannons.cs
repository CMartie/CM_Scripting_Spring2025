using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class shipCannons : MonoBehaviour
{
    public List<spawnCannonBall> cannons = new List<spawnCannonBall>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<spawnCannonBall>(FindObjectsSortMode.InstanceID).ToList();




    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();

        }
   
    }
    void FireAllCannons()
    {
        foreach (spawnCannonBall c in cannons)
        {
            c.fireCannon();

        }
    }

    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            //the mod operator % does division between the two numbers and returns the remainder. If the remainder fo something %2 is 0, its even!

            if (i % 2 == 0)
            {
                cannons[i].fireCannon();
            }

        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].fireCannon();

            }
        }
    }

    void FireAllPowerfulCannons()
    {
        foreach(spawnCannonBall c in cannons)
        {
            if(c.forcePower >= 4500)
            {
                c.fireCannon();
            }
        }
    }

    void FireAllWeakCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if (cannons[i].forcePower < 4500)
            {
                cannons[i].fireCannon();

            }
        }
    }
}
