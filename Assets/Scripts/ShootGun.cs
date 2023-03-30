using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootGun : MonoBehaviour
{
    public GameObject gun;
    public GameObject Laser;
    public Transform barrelLocation;
    public float bullets = 15.0f;
    public float shootPower;

    //public ActionBasedController controller; // The XR controller for the Oculus controller

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void FireBullet()
    {
        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f, 0f, 0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPower);
        bullets--;
        if(bullets <= 0)
        {
            Destroy(gameObject);
        }
    }


}
