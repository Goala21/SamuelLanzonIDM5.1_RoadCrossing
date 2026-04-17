using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    public AudioClip ambientSound;
    private AudioSource audioSource;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ambientSound;
        audioSource.loop = true;
        audioSource.volume = 0.5f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
