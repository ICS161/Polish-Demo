using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        IHealable healableComponent = other.GetComponent<IHealable>();
        if (healableComponent != null)
        {
            healableComponent.AddHealth(10);
        }
    }
}
