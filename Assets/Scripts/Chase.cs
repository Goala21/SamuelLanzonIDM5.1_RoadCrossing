using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    
    public float speed = 5f;
    private Animator animator;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        
        Vector3 target = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        //Move towards the player
        transform.position = target;
        
        animator.SetBool("isWalking", true);
    }
}