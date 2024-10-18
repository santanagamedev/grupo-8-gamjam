using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] zombiePrefab; // Prefab del zombi que se va a spawnear
    public float spawnInterval = 5f; // Intervalo de spawn fijo en 5 segundos
    public float spawningRange;
    public Vector2 spawnRange = new Vector2(50f, 50f); // Rango en el que se generan los zombis (50x50)

   


    private void Update()
    {
        spawningRange += Time.deltaTime;

        if (spawningRange >= spawnInterval)
        {
            SpawnZombie();
            spawningRange = 0;
        }
    }
    void SpawnZombie()
    {
        int index = Random.Range(0, zombiePrefab.Length);
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRange.x, spawnRange.x),
            0,
            Random.Range(-spawnRange.y, spawnRange.y)
        );


        Instantiate(zombiePrefab[index], spawnPosition, Quaternion.identity);


    }
}
