//using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;




public class DestroyContact : MonoBehaviour
{
    public float lives = 3f;
    public float score = 0;
    public float newSpeed = 0.5f;
    public MoveForward speedObject;
    GameObject[] attackerPrefabs;
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
        float spawnRangeX = 50f;
        float spawnPosZ = -200f;
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 30, spawnPosZ);
        int shipIndex = Random.Range(0, attackerPrefabs.Length);
        Instantiate(attackerPrefabs[shipIndex], spawnPos, attackerPrefabs[shipIndex].transform.rotation);
        
    }
}
