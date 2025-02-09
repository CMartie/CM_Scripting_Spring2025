using UnityEngine;

public class BackArrow : MonoBehaviour
{
    public GameObject GalleryBG;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leaveGallery()
    {
        GalleryBG.SetActive(true);
        GalleryBG.SetActive(false);

    }
}
