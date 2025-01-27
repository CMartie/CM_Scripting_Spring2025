using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
    int SantaClause;

    float total;
    public float mario;


    public float Yoshi = 4.8f;

    //characters are only allowed to be one letter or character on the keyboard, make sure to use an apostrophe to surround the characater you want it to represent.
    char bee = 'B';

    string fullSentence;
    string intro = "Hello World!";
    string outro = "Cya Later!";


    public string chestName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SantaClause = 56;

        SantaClause = SantaClause + 5;

        Debug.Log(SantaClause);

        Debug.Log(Yoshi);

        //Subtracts 2 from current value of yoshi
        Yoshi = Yoshi - 2;
        //Subtracts 2 as well, just different syntax
        Yoshi -= 2;

        Debug.Log("Yoshi's value is " + Yoshi);

        Debug.Log(bee);

        Debug.Log(intro);

        total = mario + Yoshi;

        Debug.Log(total);

        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
