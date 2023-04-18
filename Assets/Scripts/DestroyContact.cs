using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyContact : MonoBehaviour
{
    public float lives = 3f;
    public float score = 0;
    public float newSpeed = 10f;
    public MoveForward speedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            lives--;
            Destroy(collision.gameObject);
            if(lives <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                score += 100;
            }
            if(score % 1000 == 0)
            {
                MoveForward move = gameObject.GetComponent<MoveForward>();
                move.speed += newSpeed;
                spawnAttacker();
                
            }
        }
    }

    void spawnAttacker()
    {
        GameObject[] shipPrefabs;
        spawnRangeX = 50f;
        spawnPosZ = -200f;
        spawnTimer = 0.0f;
        spawnDelay = 10.0f;
    }
}
