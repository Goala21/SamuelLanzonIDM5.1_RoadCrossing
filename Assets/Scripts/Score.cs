using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float value = 0;
    public TMP_Text scoreText;
    private Vector3 checkpointPosition;
    private Quaternion checkpointRotation;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible") && gameObject.CompareTag("Player"))
        {
            
            value = value + 1;
            Debug.Log("Score increased to" + value);
            scoreText.text = $"score: {value:0}";
            
            checkpointPosition = other.transform.position;
            checkpointRotation = other.transform.rotation;
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
