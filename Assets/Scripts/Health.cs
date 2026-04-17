using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int totalHealth = 1;
    public TMP_Text healthText;
    public void TakeDamage()
    {
        totalHealth --;
        healthText.text = $"Health: {totalHealth:0}";
        
        GetComponent<Score>().CheckpointRespawn();
        
        if (totalHealth <= 0)
        {
            Debug.Log("Game Over");
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }   
}
