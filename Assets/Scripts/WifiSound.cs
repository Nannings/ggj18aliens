using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifiSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
    }

    public void SetSound(float angle)
    {
        if (!audioSource.isPlaying)
        {
            //audioSource.pitch
        }

        audioSource.pitch = ((angle / 100) * -1) + 2;

        //Debug.Log(((angle / 100) * -1) + 1);
    }
}
