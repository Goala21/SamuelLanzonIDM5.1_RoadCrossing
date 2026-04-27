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
    public AudioClip[] jumpSounds;
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = true;
        if (other.gameObject.tag == "Collectible")
            isGrounded = true;
    }

    void Update()
    {
        Vector3 direction = Vector3.zero;
        float rotationAngle = 0f;
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded)
        {
            jumpRequested = true;
        }
        
        // Myrigidbody.AddForce(direction * speed * Time.deltaTime);
        // Myrigidbody.AddTorque(Vector3.back * rotationAngle * rotationSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (jumpRequested && isGrounded)
        {
            Myrigidbody.AddForce((transform.forward + transform.up).normalized * speed, ForceMode.Impulse);
            isGrounded = false;
            jumpRequested = false;
            int idx = new Random().Next(0, jumpSounds.Length);
            myAudioSource.PlayOneShot(jumpSounds[idx]);
        }

        if (Myrigidbody.linearVelocity.y < 0)
        {
            Myrigidbody.linearVelocity += Vector3.up * Physics.gravity.y * (22 - 1) * Time.fixedDeltaTime;
        }
    }
}