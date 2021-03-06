﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    // You can customize your own functionalilty of get and set like this!
    //{
    //    get
    //    {
    //        Debug.Log("I'm getting the instance");
    //        return instance;
    //    }
    //    private set
    //    {
    //        instance = value;
    //    }
    //}
    public AudioSource m_BGMPlayer, m_SFXPlayer;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    //public static AudioManager GetInstance()
    //{
    //    return instance;
    //}

    //private static void SetInstance(AudioManager newInstance)
    //{
    //    instance = newInstance;
    //}

    public void PlaySFX(string clip)
    {
        //m_SFXPlayer.PlayOneShot(clip, Random.Range(0.5f, 1f));
        PlaySFX(clip, Random.Range(0.5f, 1f));
    }

    public void PlaySFX(string clip, float volume)
    {
        AudioClip newClip = Resources.Load($"Audio/{clip}") as AudioClip;
        //AudioClip newClip = Resources.Load<AudioClip>($"Audio/{clip}");
        m_SFXPlayer.PlayOneShot(newClip, volume);
    }
}
