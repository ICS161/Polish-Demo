using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        IDamageable damageableComponent = other.GetComponent<IDamageable>();
        if (damageableComponent != null)
        {
            damageableComponent.LoseHealth(10);
        }
    }
}
