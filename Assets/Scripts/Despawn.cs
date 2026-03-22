using System;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float timer = 20f;

    private void Start()
    {
        Destroy(gameObject, timer);
    }
}
