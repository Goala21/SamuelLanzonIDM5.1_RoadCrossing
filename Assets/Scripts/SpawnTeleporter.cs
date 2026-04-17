using UnityEngine;
using System.Collections;

public class SpawnTeleporter : MonoBehaviour
{
    public Transform[] spawnPoints;          // Your map spawn points
    public ChaserSpawner chaserSpawner;      // Drag ChaserManager here

    private bool isTeleporting = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTeleporting)
        {
            StartCoroutine(Teleport(other));
        }
    }

    private IEnumerator Teleport(Collider other)
    {
        isTeleporting = true;

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        yield return new WaitForSeconds(0.1f);

        // Pick a random map
        int index = Random.Range(0, spawnPoints.Length);

        // Teleport player there
        other.transform.position = spawnPoints[index].position;
        other.transform.rotation = spawnPoints[index].rotation;

        // Spawn chaser on the SAME map
        chaserSpawner.SpawnInMap(index);

        yield return new WaitForSeconds(1f);
        isTeleporting = false;
    }
}