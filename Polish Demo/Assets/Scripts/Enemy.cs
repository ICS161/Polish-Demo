using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 100;

    public void AddHealth(int healthDelta)
    {
        health += healthDelta;
    }

    public void LoseHealth(int healthDelta)
    {
        health -= healthDelta;
    }
}
