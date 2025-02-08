using UnityEditor.Rendering;
using UnityEngine;

public class ZoomFunction : MonoBehaviour
{
    public GameObject CameraBG;

    public GameObject ZoomSlider;

    public Vector3 BGscale;

    public float zoom = .5f;

    public Vector3 ZoomOut;

    public Vector3 SliderDown;

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

                 }
        }

        // this part of the function zooms in

        if (CameraBG.transform.localScale != (Vector3.one * 4))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                {
            CameraBG.transform.localScale += ZoomOut * -1;

            ZoomSlider.transform.localPosition += SliderDown * -1;

              }
        }
          
    }

}