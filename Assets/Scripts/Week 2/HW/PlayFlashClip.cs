using UnityEngine;


public class PlayFlashClip : MonoBehaviour
{
  //this script shows the white screen while "taking photo"

    public GameObject whiteScreen;
    public AudioQueue cameraNoise;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void playCameraShutter()
    {
        cameraNoise.selectionNoise();

        whiteScreen.SetActive(true);

    }

   /* public void PlayVideo()
    {
        
        
            
        flashVideo.Play();
        

    }
   */
}


         
