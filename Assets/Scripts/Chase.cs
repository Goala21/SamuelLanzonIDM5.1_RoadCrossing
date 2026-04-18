using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    private Animator animator;

    public float speed = 5f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player == null) return; 

        Vector3 target = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        transform.position = target;
        transform.LookAt(player);

        animator.SetBool("isWalking", true);
    }
}