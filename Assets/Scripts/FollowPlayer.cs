using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    private Animator animator;
    private Rigidbody myRigidBody;

    public float speed = 5f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        
        animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody>();
        
        animator.SetBool("isWalking", true);
    }

    void FixedUpdate()
    {
        if (player == null) return; 

        Vector3 dirToPlayer = player.position - transform.position;
        myRigidBody.linearVelocity = dirToPlayer.normalized * speed;
        
        Quaternion targetRotation = Quaternion.LookRotation(dirToPlayer);
        myRigidBody.MoveRotation(targetRotation);

    }
}