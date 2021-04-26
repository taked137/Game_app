using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBGM : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        audioSource.PlayOneShot(sound1);
    }
}