using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 30f;
    public Vector3 direction = Vector3.back;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
