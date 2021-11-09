using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    public AudioSource audioData;

    void Awake()
    {
        if(!audioData.isPlaying)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }else
        {
            
        }
    }
}
