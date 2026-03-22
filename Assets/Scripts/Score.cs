using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float value = 0;
    public TMP_Text scoreText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            
            value = value + 1;
            Debug.Log("Score increased to" + value);
            scoreText.text = $"score: {value:0}";
        }    
    }
}
