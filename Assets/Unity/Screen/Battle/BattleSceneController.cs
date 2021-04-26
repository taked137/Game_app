using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneController : MonoBehaviour
{
    public static string kindId;

    public AudioSource audioSource;
    public AudioClip victory;

    public void AudioStop()
    {
        audioSource.Stop();
    }
    public void AudioPlay()
    {
        audioSource.PlayOneShot(victory);
    }
}
