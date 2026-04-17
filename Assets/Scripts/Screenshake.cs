using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Screenshake : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration;
    
    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(Shake());
        }
    }

    private IEnumerator Shake()
    {
        float timer = 0;
        Vector3 originalPosition = transform.position;

        while (timer <duration)
        {
            transform.position = Random.insideUnitCircle * curve.Evaluate(timer / duration);
            
            timer += Time.deltaTime;
            yield return null;
        }
        
        transform.position = originalPosition;
    }
}
