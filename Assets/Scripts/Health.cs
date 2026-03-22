using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int totalHealth = 1;
    public TMP_Text healthText;
    public void TakeDamage()
    {
        totalHealth --;
        healthText.text = $"Health: {totalHealth:0}";
        
        if (totalHealth <= 0)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            
        }
    }
}
