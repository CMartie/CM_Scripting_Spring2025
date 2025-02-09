using UnityEngine;
using UnityEngine.Video;

public class PlayFlashClip : MonoBehaviour
{
   // public VideoPlayer flashVideo;
    public ShowGallery showVideo;
    public GameObject whiteScreen;



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
        showVideo.galleryBG = whiteScreen;
    }

   /* public void PlayVideo()
    {
        
        
            
        flashVideo.Play();
        

    }
   */
}


         
