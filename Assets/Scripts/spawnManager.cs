using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    private float spawnOffset = 50f;
    private float seconds = 0.5f;
    private float repeating = 5f;
    private float numRange = 10f;
    private float limZ = -30f;

    void Start()
    {
        //Repetición de obstáculos.
        InvokeRepeating("spawnObstacle", time:seconds, repeatRate:repeating);
    }

   
    public void spawnObstacle()
    {
        // Spawn de obstáculos.
        randomY = Random.Range(-numRange, numRange);
        spawnPos = new Vector3(0, randomY, spawnPos.z + spawnOffset);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

}
