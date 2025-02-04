using UnityEngine;

public class ScriptreferencePractice : MonoBehaviour
{

    public SideEyeCat eyeController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eyeController.scaleIncrease = 5f;
        eyeController.Rotatecriminalsideeye();


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
