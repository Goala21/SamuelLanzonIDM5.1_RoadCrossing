using System;
using UnityEngine;

public class RespawnAfterDeath : MonoBehaviour
{
    public GameObject respawnPoint;
    public int Health = 1;
    public TMPro.TextMeshProUGUI healthBar;
    public void OnCollisionEnter(Collision other)
        
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().TakeDamage();

            if (Health == 0)
            {
                Destroy(gameObject);
                Debug.Log("Game Over");
                
            }
        }
    }
}
