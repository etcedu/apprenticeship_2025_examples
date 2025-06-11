using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnWaitTime;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnWaitTime);
    }

    public void SpawnEnemy()
    {
        //generate a random position
        Vector3 spawnPosition = transform.position;
        float randomY = (Random.value * 8) - 4;
        spawnPosition = spawnPosition + new Vector3(0f, randomY,0f);

        //Instantiate our enemy
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, transform);
    }
}
