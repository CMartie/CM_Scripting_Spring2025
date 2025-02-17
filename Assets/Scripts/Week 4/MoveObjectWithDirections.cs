using UnityEngine;

public class MoveObjectWithDirections : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public float speed = 4f;
    public bool hasReachedDestination = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    /* void Update()
     {
         //this  gets the directin every frame, updating when point 1 moves
         //this causes the point 1 object to stadly creep towards point 2 and slows on approach because the driection is slowly getting smaller

         Vector3 direction;

         direction = point2.transform.position - point1.transform.position;


         point1.transform.position += direction * Time.deltaTime;

     }*/

    /* private void Update()
     {
    //this version normalizes the direction of the movement vector, so it travels steadily toward point2, multiplied by a speed variable so it can speed up
    //unfortunetley it jitters as it reaches the edn as it tries to get to the exact point

         Vector3 direction;

         direction = point2.transform.position - point1.transform.position;

         direction = direction.normalized;
         Debug.Log(direction);

         point1.transform.position += direction * speed * Time.deltaTime;

     }*/

    /*   private void Update()
       {
    //in this version it checks the distance between the two points and if thedistance  is small enough it will stop trying to move point 1 to point 2 and will teleport point 1 to point 2 to be right on top of it
           Vector3 direction;
    //however it is still teleporting it every singel frame and i dont want it to run this logic when it reaches its proper location
           direction = point2.transform.position - point1.transform.position;

           direction = direction.normalized;


           Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

           if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
           {
               point1.transform.position = point2.transform.position;
           }
           else
           {
               point1.transform.position += direction * speed * Time.deltaTime;
           }



       }*/

    private void Update()
    {
        //this version of update will only run if point 1 hasnt reached its destination- now itll stop runing all code in upate once it has reached its destination
        //becuse we have the hasReachedDestination bool on false, but onece we have the point 1 at postition it turns to true stpping any other code in this update
        if(hasReachedDestination == false)
        {
            Vector3 direction;

            direction = point2.transform.position - point1.transform.position;

            direction = direction.normalized;


            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }
        


    }
}
