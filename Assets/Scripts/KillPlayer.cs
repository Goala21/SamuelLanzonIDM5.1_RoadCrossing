using System;
using Unity.VisualScripting;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [Header("HitSound")]
    public AudioClip hitSound;

    public AudioSource hitSource;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().TakeDamage();
            hitSource.PlayOneShot(hitSound);
        }
        

    }
}