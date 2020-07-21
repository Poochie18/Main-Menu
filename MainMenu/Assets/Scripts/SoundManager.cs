using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;
    public AudioSource audioSource;
    public float volumeLvl;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        volumeLvl = audioSource.volume;
    }
    
    public void SoundVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
