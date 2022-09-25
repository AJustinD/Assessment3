using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Music : MonoBehaviour
{

    public AudioClip intro;
    public AudioClip BGMusic;

    void Start()
    {
        StartCoroutine(playSound());
    }

    IEnumerator playSound()
    {
        GetComponent<AudioSource>().clip = intro;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(intro.length);
        GetComponent<AudioSource>().clip = BGMusic;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }
}