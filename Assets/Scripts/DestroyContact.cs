//using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;




public class DestroyContact : MonoBehaviour
{
  
    public float lives = 3f;
    public float score = 0;
    public float newSpeed = 20f;
    public MoveForward speedObject;
    GameObject[] attackerPrefabs;
    GameObject[] gameObjectsToTarget;
    public Text ScoreTexts;

 
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
        gameObjectsToTarget = GameObject.FindGameObjectsWithTag("Ship");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            lives--;
            Destroy(collision.gameObject);
            if (lives <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                score++;
                ScoreTexts.text = score.ToString();

            }
            if (score % 5 == 0)
            {
                foreach (GameObject go in gameObjectsToTarget)
                {
                    MoveForward move = go.GetComponent<MoveForward>();
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
}
