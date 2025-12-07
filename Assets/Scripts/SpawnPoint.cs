using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;     // Drag your prefab here
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawn = 1f;

    private float spawnTime;

    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(randomX, randomY, 0) + transform.position;
        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }
}