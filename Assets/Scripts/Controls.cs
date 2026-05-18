using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour

{
    public TMP_Text control;
        
    void Start()
    {
        control.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            control.gameObject.SetActive(false);
        }
        
    }
}
