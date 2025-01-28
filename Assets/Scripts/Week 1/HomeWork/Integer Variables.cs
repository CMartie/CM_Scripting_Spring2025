using UnityEngine;

public class IntegerVariables : MonoBehaviour
{
    int jake = 5;
    int kevin = 10;
    int david = 45;
    int total;

        


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        jake = jake + 5 + kevin / 2;
        david = david - jake;
        kevin = jake + kevin + 2;

        total = jake + kevin + david;

        Debug.Log(total);

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
