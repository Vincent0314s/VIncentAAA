using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Vector3 spawnRange;
    public GameObject enemy;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f,1f);
    }

    void SpawnEnemy() {
        Vector3 randomPos = new Vector3(Random.Range(spawnRange.x, -spawnRange.x), 2, Random.Range(spawnRange.z, -spawnRange.z));
        if ((randomPos.x >= 0 && randomPos.x < 2) && (randomPos.z >= 0 && randomPos.z <=2)) {
            randomPos = new Vector3(Random.Range(spawnRange.x, -spawnRange.x), 2, Random.Range(spawnRange.z, -spawnRange.z));
        }
        Instantiate(enemy, randomPos, Quaternion.identity);
    }
}
