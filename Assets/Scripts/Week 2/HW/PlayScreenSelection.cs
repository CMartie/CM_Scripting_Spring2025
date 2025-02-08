using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayScreenSelection : MonoBehaviour
{
    public GameObject PlayScreen;

    public GameObject PlayScreen2;

    public GameObject BlackScreen;

    public GameObject CameraHUD;

    public GameObject CameraBG;

    public GameObject ZoomSlider;

    




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        PlayerScreenNavigation();

        nextArea();


    }

    private void PlayerScreenNavigation()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayScreen.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayScreen.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BlackScreen.SetActive(true);
            Destroy(PlayScreen2);
            Destroy(PlayScreen);


        }
       // if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //Destroy(BlackScreen);


        }

    }

    public void
        nextArea()
        {
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            CameraBG.SetActive(true);
            CameraHUD.SetActive(true);
            ZoomSlider.SetActive(true);

        }
        
        

        
    
        

        
        
    }



}










    
