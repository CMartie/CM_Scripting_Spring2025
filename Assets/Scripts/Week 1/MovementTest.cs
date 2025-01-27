using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

    //2 slashes and the green text after is called a comment. This is not code it is just for notes

    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        Debug.Log("Hello World!");

        //in reference to the object this script is on, get reference to its transform components and get reference to the transforms position, and set it (=) to Vector3.zero (which means 0,0,0)

        this.transform.position = startingPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //Move direction is currently (1,0,1)
        this.transform.position += moveDirection * speed * Time.deltaTime;
        //Multiplying byt time delta time means "per second" instead of "per frame" in update

        Debug.Log("Am I destined for the black Abyss?");

    }
}
