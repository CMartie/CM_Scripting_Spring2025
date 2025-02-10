using UnityEngine;

public class AudioQueue : MonoBehaviour
{
    //this script plays the audio while moving or selecting

    public AudioSource selectAudio;
    public AudioSource playAudio;
    public AudioSource cameraNoise;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  //this plays the small tin selection noise
    public void selectionNoise()
    {
        selectAudio.Play();

    }

  //this plays the loud selection noise for special features
    public void heavyPlayNoise()
    {
        playAudio.Play();
    }

    public void camerShutterNoise()
    {
        playAudio.Play();

    }
}
