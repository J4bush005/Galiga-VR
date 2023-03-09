using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public GameObject[] shipPrefabs;
    private float spawnRangeX = 50f;
    private float spawnPosZ = -200f;
    public float spawnTimer = 0.0f;
    public float spawnDelay = 10.0f;
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
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 30, spawnPosZ);
            int shipIndex = Random.Range(0, shipPrefabs.Length);
            Instantiate(shipPrefabs[shipIndex], spawnPos, shipPrefabs[shipIndex].transform.rotation);
            spawnTimer = 0.0f;
        }
    }
}
