using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int totalHealth = 3;
    public TMP_Text healthText;
    private Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    public void TakeDamage()
    {
        totalHealth--;
        healthText.text = $"Health: {totalHealth:0}";

        if (totalHealth <= 0)
        {
            Debug.Log("Game Over");
            gameOverScreen.SetActive(true);
            Time.timeScale = 0.00001f;
        }
        else
        {
            score.CheckpointRespawn();
        }
    }
}