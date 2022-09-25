using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public AudioSource footstepSource;
    public AudioClip footstepClip;
    public AudioSource backGroundMusic;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (footstepSource.isPlaying == false)
        {
            footstepSource.clip = footstepClip;
            footstepSource.volume = 0.8f;
            footstepSource.Play();
            backGroundMusic.volume = 0.5f;
        }
        else if (footstepSource.isPlaying == true)
        {
            footstepSource.Stop();
            backGroundMusic.volume = 1.0f;
        }
    }
}
