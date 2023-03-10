using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    //public ActionBasedController controller; // The XR controller for the Oculus controller

    void Start()
    {
       XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
       grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bulletPrefab);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        transform.Translate(Vector3.forward * Time.deltaTime * fireSpeed);
        Destroy(spawnedBullet, 5);
    }


}
