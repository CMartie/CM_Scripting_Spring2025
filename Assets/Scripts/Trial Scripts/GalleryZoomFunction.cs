
using UnityEngine;

public class GalleryZoomFunction : MonoBehaviour
{
    public GameObject CameraBG;

   

    public Vector3 picScale;



    public Vector3 zoomOut;


   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ZoomTool()
    //this part of the function zooms out
    {
        if (CameraBG.transform.localScale != (Vector3.one))
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                CameraBG.transform.localScale += zoomOut;

                

            }
        }

        // this part of the function zooms in

        if (CameraBG.transform.localScale != (Vector3.one * 4))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                CameraBG.transform.localScale += zoomOut * -1;

                

            }
        }

    }

}