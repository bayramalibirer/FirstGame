using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnX = 10f;
    public float spawnZ = 10f;

    private void Start()
    {
        InvokeRepeating("SpawnFruit", 2, 1);
    }
    void SpawnFruit()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnX, spawnX), 1, spawnZ);
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, Quaternion.identity);

    }
}
