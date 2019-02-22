using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float defaultShakeDuration = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(TriggerShake());
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(TriggerShake(shakeMagnitude: 20f));
        }
    }

    public IEnumerator TriggerShake(float? shakeDuration = null, float shakeMagnitude = 0.7f, float dampingSpeed = 1.0f)
    {
        // If shakeDuration is null, use defaultShakeDuration
        float actualShakeDuration = shakeDuration ?? defaultShakeDuration;

        Vector3 initialPosition = transform.localPosition;

        while (actualShakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;

            yield return null;
        }
        shakeDuration = 0f;
        transform.localPosition = initialPosition;
    }
}
