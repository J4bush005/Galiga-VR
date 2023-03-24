using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShhotShip : MonoBehaviour
{
    public GameObject bulletPrefab; // reference to the bullet prefab
    public float fireInterval = 2f; // interval between bullet fires
    public float bulletSpeed = 10f; // speed of the fired bullet

    private float timeUntilNextFire;

    void Update()
    {
        timeUntilNextFire -= Time.deltaTime;
        if (timeUntilNextFire <= 0f)
        {
            FireBullet();
            timeUntilNextFire = fireInterval;
        }
    }

    void FireBullet()
    {
        Vector3 bulletDirection = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f) * Vector3.forward;
        GameObject bulletObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody bulletRigidbody = bulletObject.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bulletDirection * bulletSpeed;
    }
}
