using UnityEngine;

public class SideEyeCat : MonoBehaviour
{
    public GameObject criminalSideEye;

    public float scaleIncrease = .5f;

    public GameObject YouDiedScreen;

    public Transform teleporttansform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        criminalSideEye.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if (criminalSideEye.transform.localScale.x > 9)
        {
            YouDiedScreen.SetActive(true);
        }
    }

    public void ResetcriminalSideEye()
    {
        criminalSideEye.transform.localScale = Vector3.one;
        scaleIncrease += .5f;

    }

    public void Rotatecriminalsideeye()
    {
        //the folllowig line will rotate the folllowing emage by -90 degrees in the z direction by creating a new vector3

        criminalSideEye.transform.Rotate(new Vector3(0f, 0f, -90f));
        
        //additionally you can declare the vector 3 as a function in first declarations
    }

    public void teleportSideEye()
    {
        criminalSideEye.transform.position = teleporttansform.position;

    }
}
