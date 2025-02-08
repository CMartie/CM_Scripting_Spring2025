using UnityEngine;

public class PlayFlashClip : MonoBehaviour
{
    public GameObject flashVideo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            flashVideo.SetActive(true);
        }
    }
}
