using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstFireShoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(burstFireShotCoroutine());
        }
    }

    IEnumerator burstFireShotCoroutine()
    {
        // BurstFire
        for (int i = 0; i < 3; i++)
        {
            GameObject newBullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 5f, ForceMode.Impulse);
            Destroy(newBullet, 2f);

            yield return new WaitForSeconds(0.1f);
        }
    }
}
