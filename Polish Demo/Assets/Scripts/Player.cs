using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IHealable, IDamageable
{
    public int health = 100;

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
        AudioManager.instance.PlaySFX("Shoot");
    }

    void Jump()
    {
        AudioManager.instance.PlaySFX("Jump");
    }

    public void AddHealth(int healthDelta)
    {
        health += healthDelta;
    }

    public void LoseHealth(int healthDelta)
    {
        health -= healthDelta;
    }
}
