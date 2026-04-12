using UnityEngine;
using System.Collections;

public class SpawnTeleporter : MonoBehaviour
{
    public Transform[] spawnPoints;
    private bool isTeleporting = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isTeleporting)
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

        int index = Random.Range(0, spawnPoints.Length);
        other.transform.position = spawnPoints[index].position;
        other.transform.rotation = spawnPoints[index].rotation;

        yield return new WaitForSeconds(1f);
        isTeleporting = false;
    }
}