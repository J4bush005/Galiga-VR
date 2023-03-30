
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawn : MonoBehaviour
{
    public GameObject[] gunPrefabs;
    public float spawnTimer = 0.0f;
    public float spawnDelay = 10.0f;
    public float spawnRangeX = 7.0f;
    public float spawnPosZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnDelay)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 17, spawnPosZ);
            int shipIndex = Random.Range(0, gunPrefabs.Length);
            Instantiate(gunPrefabs[shipIndex], spawnPos, gunPrefabs[shipIndex].transform.rotation);
            spawnTimer = 0.0f;
        }
    }
}
