using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    /// <summary>
    /// Returns a random position around the position of this object, in a range of 4f in the y direction
    /// </summary>
    /// <returns></returns>
    private Vector3 RandomPosition()
    {
        Vector3 pos = transform.position;
        pos += new Vector3(0f, ((Random.value * 8f) - 4f), 0f);
        return pos;
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomPosition(), Quaternion.identity, transform);
    }
}   
