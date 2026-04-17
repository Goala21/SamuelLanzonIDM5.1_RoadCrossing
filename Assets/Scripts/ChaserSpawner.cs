using UnityEngine;
using TMPro;

public class ChaserSpawner : MonoBehaviour
{
    public GameObject chaserPrefab;      // Drag your chaser prefab here
    public Transform[] spawnPoints;      // One spawn point per map

    public TMP_Text chaserText;
    private GameObject currentChaser;

    public void SpawnInMap(int mapIndex)
    {
        // Destroy old chaser if exists
        if (currentChaser != null)
        {
            Destroy(currentChaser);
        }

        // Spawn new chaser at the correct map after 10 seconds
        StartCoroutine(SpawnAfterDelay(mapIndex));
        
    }

    private System.Collections.IEnumerator SpawnAfterDelay(int mapIndex)
    {
        yield return new WaitForSeconds(10f);
        currentChaser = Instantiate(chaserPrefab, spawnPoints[mapIndex].position, spawnPoints[mapIndex].rotation);
    }
}