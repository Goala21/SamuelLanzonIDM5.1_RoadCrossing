using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody Myrigidbody;
    public float rotationSpeed = 150f;
    public float speed = 200f;
    private bool isGrounded = true;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = true;
        if (other.gameObject.tag == "Collectible")
            isGrounded = true;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        float rotationAngle = 0f;
        
        if (Keyboard.current.spaceKey.isPressed && isGrounded)
        {
            Myrigidbody.AddForce(transform.forward * 60 + transform.up * 50, ForceMode.Impulse);
            isGrounded = false;
        }
        
        
        Myrigidbody.AddForce(direction * speed * Time.deltaTime);
        Myrigidbody.AddTorque(Vector3.back * rotationAngle * rotationSpeed * Time.deltaTime);
    }
}
