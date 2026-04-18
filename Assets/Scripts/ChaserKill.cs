using UnityEngine;

public class ChaserKill : MonoBehaviour
{
    private GameObject gameOverScreen;

    private void Start()
    {
        
        Canvas canvas = FindObjectOfType<Canvas>();
        gameOverScreen = canvas.transform.Find("GameoverScreen").gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverScreen.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}