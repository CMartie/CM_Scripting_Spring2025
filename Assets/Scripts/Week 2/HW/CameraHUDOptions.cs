
using UnityEngine;

public class CameraHUDOptions : MonoBehaviour
{
    public GameObject CameraHUD;

    public GameObject CameraBG;

    public GameObject ZoomSlider;

    public PlayScreenSelection Continue;

    public Vector3 BGscale;

    public int count = 0;

    public ZoomFunction zoomController;


   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        CameraBG.transform.localScale = BGscale * 4;

       

    }

    // Update is called once per frame
    void Update()
    {
       
        
            zoomController.ZoomTool();
        


    }

   


}
