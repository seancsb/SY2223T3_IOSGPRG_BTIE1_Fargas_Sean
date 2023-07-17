using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _meleeEnemyPrefab;
    [SerializeField] private GameObject _rangedEnemyPrefab;
    [SerializeField] private GameObject _bossEnemyPrefab;

    private void Start()
    {
        float randomX;
        float randomY;
        Vector3 position;

        for (int i = 0; i < 5; i++)
        {
            randomX = Random.Range(-5, 5);
            randomY = Random.Range(-5, 5);
            position = new Vector3(randomX, randomY, 0);

            GameObject meleeEnemyGO = Instantiate(_meleeEnemyPrefab, position, Quaternion.identity);
            meleeEnemyGO.transform.parent = transform;

            MeleeEnemy meleeEnemy = meleeEnemyGO.GetComponent<MeleeEnemy>();

            meleeEnemy.Initialize("Barbarian", 100, 5);
        }

        for (int i = 0; i < 3; i++)
        {
            randomX = Random.Range(-5, 5);
            randomY = Random.Range(-5, 5);
            position = new Vector3(randomX, randomY, 0);

            GameObject rangedEnemyGO = Instantiate(_rangedEnemyPrefab, position, Quaternion.identity);
            rangedEnemyGO.transform.parent = transform;

            RangedEnemy rangedEnemy = rangedEnemyGO.GetComponent<RangedEnemy>();

            rangedEnemy.Initialize("Archer", 75, 7.5f);
        }

        randomX = Random.Range(-5, 5);
        randomY = Random.Range(-5, 5);
        position = new Vector3(randomX, randomY, 0);

        GameObject bossEnemyGO = Instantiate(_bossEnemyPrefab, position, Quaternion.identity);
        bossEnemyGO.transform.parent = transform;

        BossEnemy bossEnemy = bossEnemyGO.GetComponent<BossEnemy>();

        bossEnemy.Initialize("Boss Bobby", 1000, 4);
    }
}
