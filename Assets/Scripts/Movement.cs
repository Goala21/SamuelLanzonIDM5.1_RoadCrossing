using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;

public class Movement : MonoBehaviour
{
    [Header("sounds")]
    public AudioClip jumpSound;
    
    
    public Rigidbody Myrigidbody;
    public float rotationSpeed = 150f;
    public float speed = 200f;
    private bool isGrounded = true;
    private bool jumpRequested = false;
    public AudioSource myAudioSource;
    private ParticleSystem myParticleSystem;

    private void Start()
    {
        myParticleSystem = transform.Find("Dirt").GetComponent<ParticleSystem>();
        myParticleSystem.Stop();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = true;
        if (other.gameObject.tag == "Collectible")
            isGrounded = true;
    }

    private void FixedUpdate()
    {
        // if (Myrigidbody.linearVelocity.y < 0)
        // {
        //     Myrigidbody.linearVelocity += Vector3.up * Physics.gravity.y * (22 - 1) * Time.fixedDeltaTime;
        // }
    }

    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Myrigidbody.linearVelocity = transform.forward * speed;
            myAudioSource.Play();
            myParticleSystem.Play();
        }
        else
        {
            Myrigidbody.linearVelocity = Vector3.zero;
            myParticleSystem.Stop();
            myAudioSource.Stop();
        }
        
        // if (isGrounded)
        // {
        //     Myrigidbody.linearVelocity = (transform.forward + transform.up).normalized * speed;
        //     isGrounded = false;
        //     jumpRequested = false;
        //     int idx = new Random().Next(0, jumpSounds.Length);
        //     myAudioSource.PlayOneShot(jumpSounds[idx]);
        // }
    }
}