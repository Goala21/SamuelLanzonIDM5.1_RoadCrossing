using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 1;
    public TMPro.TextMeshProUGUI healthText;
    public void TakeDamage()
    {
        health = health - 1;
        healthText.text = "Health: " + health;
        
        if (health <= 0)
        {
            Debug.Log("Game Over");
            Destroy(gameObject); 
            
        }
    }
}
