using UnityEngine;

public class PlayScreenSelection : MonoBehaviour
{
    public GameObject PlayScreen;

    public GameObject PlayScreen2;

    public GameObject BlackScreen;

    public GameObject CameraHUD;

    public GameObject CameraBG;

    public GameObject ZoomSlider;

    public AudioQueue selection;




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
            selection.selectionNoise();
            PlayScreen.SetActive(false);
            
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
           selection.selectionNoise();
            PlayScreen.SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            selection.heavyPlayNoise();

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










    
