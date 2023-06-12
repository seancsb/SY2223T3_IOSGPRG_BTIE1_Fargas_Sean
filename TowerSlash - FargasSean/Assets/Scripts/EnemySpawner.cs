using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private float _randX;
    [SerializeField] private float _randY;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    // List of Enemies

    [Header("References")]
    public GameObject[] objecsToInstantiate;
    [SerializeField] private List<GameObject> enemies;

    private void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    private void Update()
    {
        updateTimer();
    }

    private void updateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    // Spawn Enemies
    public void spawnEnemy()
    {
        int n = Random.Range(0, objecsToInstantiate.Length);
        GameObject enemy = Instantiate(objecsToInstantiate[n], new Vector3(_randX, _randY, 0), Quaternion.identity);

        enemies.Add(enemy);
    }
}
