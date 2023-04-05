using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShhotShip : MonoBehaviour
{
    public GameObject ship;
    public GameObject Laser; // reference to the bullet prefab
    public float fireInterval = 2f; // interval between bullet fires
    public float bulletSpeed = 10f; // speed of the fired bullet
    public Transform barrelLocation;

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

        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f, 0f, 0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * bulletSpeed);
    }
}
