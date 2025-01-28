using UnityEngine;

public class MovementHW : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 movementDirection;
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = startingPosition;

        Debug.Log("Off I Go!");

        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += movementDirection * speed * Time.deltaTime;

        
    }
}
