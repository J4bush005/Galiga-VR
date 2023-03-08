using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public GameObject[] shipPrefabs;
    private float spawnRangeX = 50f;
    private float spawnPosZ = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int shipIndex = Random.Range(0, shipPrefabs.Length);
        Instantiate(shipPrefabs[shipIndex], spawnPos, shipPrefabs[shipIndex].transform.rotation);
    }
}
