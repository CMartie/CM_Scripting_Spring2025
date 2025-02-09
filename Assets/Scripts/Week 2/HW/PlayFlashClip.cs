using UnityEngine;
using UnityEngine.Video;

public class PlayFlashClip : MonoBehaviour
{
    public VideoPlayer flashVideo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Backspace))
       // {
      //      flashVideo.Play();
      //  }
    }

    public void PlayVideo()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            flashVideo.Play();
        }

    }
}


         
