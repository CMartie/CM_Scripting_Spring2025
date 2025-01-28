using UnityEngine;

public class StringVariables : MonoBehaviour
{
    public string barthelemew;
    public string steven;
    public string jacob;
    string total;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = barthelemew + steven + jacob;

        Debug.Log(total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
