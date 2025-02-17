using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 5f;

    public float timerEnd = 0f;

    public bool hasFinishedTimer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if(timerCountingDown <= timerEnd)
        {
            Debug.Log("i've counted down");

                timerCountingDown = 0f;
        }
    }
}
