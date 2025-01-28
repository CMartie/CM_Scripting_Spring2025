using UnityEngine;

public class FloatVariables : MonoBehaviour
{
    public float bob;
    public float joshua;
    public float thomas;
    float total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        total = bob - 3.1f * joshua + thomas;






        Debug.Log(total);



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
