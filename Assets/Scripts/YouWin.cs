using System;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject YouWinScreen;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            YouWinScreen.SetActive(true);
    }
}
