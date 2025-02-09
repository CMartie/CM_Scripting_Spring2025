using UnityEngine;

public class GalleryZoom : MonoBehaviour
{
    public GalleryZoomFunction largeZoom;
    public GameObject pictureTaken;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPicture()
    {
        pictureTaken.SetActive(true);
        
    }

    public void galleryZoomFunction()
    {

        largeZoom.zoomOut += Vector3.one;


    }
    
}
