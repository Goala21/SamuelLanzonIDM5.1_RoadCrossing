using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] thingToSpawn;
    public Transform[] spawnPoints;
    public bool isSpawning = false;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    void Spawn()
    {
        if (!isSpawning) return;

        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform point = spawnPoints[spawnIndex];

        int objectIndex = Random.Range(0, thingToSpawn.Length);
        GameObject objectToSpawn = thingToSpawn[objectIndex];

        Instantiate(objectToSpawn, point.position, point.rotation);
    }
}
