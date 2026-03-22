using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject thingToSpawn;
    public float duration = 2f;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    private void Spawn()
    {
        int index = Random.Range(0, spawnPoints.Length);
        
        Transform point = spawnPoints[index];
        
        Instantiate(thingToSpawn, point.position, point.rotation);
        
    }

}
