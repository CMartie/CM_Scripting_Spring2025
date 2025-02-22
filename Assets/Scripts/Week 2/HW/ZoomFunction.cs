
using System.Threading;
using UnityEngine;

public class ZoomFunction : MonoBehaviour
{
    //this script is the zooming function during the camera HUD

    public GameObject CameraBG;

    public GameObject ZoomSlider;

    public Vector3 BGscale;

    public PlayScreenSelection playDebug;

    public Vector3 ZoomOut;

    public Vector3 SliderDown;

    public CameraHUDOptions HUD;




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
            CameraBG.transform.localScale += ZoomOut;

            ZoomSlider.transform.localPosition += SliderDown;

                HUD.count += 1;
                Debug.Log("zoomed" + HUD.count);

            }
        }

        // this part of the function zooms in

        if (CameraBG.transform.localScale != (Vector3.one * 4))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                {
            CameraBG.transform.localScale += ZoomOut * -1;

            ZoomSlider.transform.localPosition += SliderDown * -1;
                
                HUD.count += 1;
                Debug.Log("zoomed" + HUD.count);

              }

        }

        


        
          
    }

}