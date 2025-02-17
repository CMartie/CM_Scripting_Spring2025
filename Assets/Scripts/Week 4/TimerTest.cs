using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;

    public float timerMaxDuration = 3f;

    public bool hasFinishedTimer = false;

    public GameObject cube;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //when using randon range the first integer is inclusive but the last is not on whole integers, but if you put f after the number it will inlcude all numbers in between includig decimals

        timerMaxDuration = Random.Range(1, 5);

        Invoke("moveCubeRight", timerMaxDuration);

    }

    // Update is called once per frame
  /*  void Update()
    {
        //in this update once the timer finishes it changes a bool called hasFinishedTimer to true, which prevents addiional logic fro being run on the timer
        // this is how you can make sure soething runs only once

        if (hasFinishedTimer == false)
        { 
            timerCountingUp += Time.deltaTime;
           // Debug.Log(timerCountingUp);

           if(timerCountingUp >= timerMaxDuration)
             {
            hasFinishedTimer = true;
            Debug.Log("Reached End of Timer");
             }
             
        }
      
    }*/

 /*void Update()
    {
        //in this update the counter counts up, but once it reaches max duration it will move the cube to the right without time delta time becasue we want to move in one motio nand not over time
        //additionally we reset the timer counting up to 0 so that it may count back up to 3 again and move the cube once more
        
            timerCountingUp += Time.deltaTime;
            

            if (timerCountingUp >= timerMaxDuration)
            {
                Debug.Log("Reached End of Timer");
              moveCubeRight();
          //cube.transform.position += Vector3.right;
              timerCountingUp = 0f;
            }


        } */
         void moveCubeRight()
    {
        cube.transform.position += Vector3.right;
        if (cube.transform.position.x < 10)
        {
            Invoke("moveCubeRight", timerMaxDuration);
        }
        
    }

    }

