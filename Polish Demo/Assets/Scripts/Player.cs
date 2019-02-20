using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //AudioSource m_audioSource;

    //void Awake()
    //{
    //    m_audioSource = this.GetComponent<AudioSource>();
    //}

    //public AudioClip shootSFX;
    //public AudioClip jumpSFX;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Shoot()
    {
        //m_audioSource.Play();
        AudioManager.instance.PlaySFX("Shoot");
    }

    void Jump()
    {
        AudioManager.instance.PlaySFX("Jump");
    }
}
