using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaAudio : MonoBehaviour
{
    private AudioSource audioToPlay;
    // Start is called before the first frame update
    void Start()
    {
        audioToPlay = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
            audioToPlay.Stop();
       }
    }
    
    public void PlayAudio()
    {
        audioToPlay.Play();
    }
}
