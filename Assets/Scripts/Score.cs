using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float elapsedTime = 0f;
    private Vector3 checkpointPosition;
    private Quaternion checkpointRotation;
    private EnemySpawner enemySpawner;

    void Start()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        timerText.text = "Score: " + Mathf.FloorToInt(elapsedTime).ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            checkpointPosition = other.transform.position;
            checkpointRotation = other.transform.rotation;

            if (enemySpawner != null)
            {
                
                enemySpawner.isSpawning = true;
            }
        }
    }

    public void CheckpointRespawn()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        if (rigidBody != null)
        {
            rigidBody.linearVelocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
        }

        transform.position = checkpointPosition;
        transform.rotation = checkpointRotation;
    }
}