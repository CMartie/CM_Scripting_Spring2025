
using UnityEngine;

public class CameraHUDOptions : MonoBehaviour
{
    public GameObject CameraHUD;

    public GameObject CameraBG;

    public GameObject ZoomSlider;

    public PlayScreenSelection Continue;

    public Vector3 BGscale;

    public Vector3 Zoom;

   

    public float zoomOut;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Continue.nextArea();

        CameraBG.transform.localScale = BGscale * 2;

       


       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZoomFunction()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ZoomSlider.transform.position = Vector3.one;
            zoomOut += -5f;

            CameraBG.transform.localScale -= BGscale;

        }

    }
    

}
