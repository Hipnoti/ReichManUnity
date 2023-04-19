using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class MyFirstScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    [Header("Scale")] [SerializeField] [Tooltip("This is the scale range from the random scale")]
    private Vector2 scaleRandomRange;
    [SerializeField] private float timeForScaleChange = 5;

    private float timeUntilNextScaleChange;
    private bool scaleChanged = false;

    private Coroutine currentCoroutine = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Reichman!");
        Debug.Log("We are having fun!");
        Debug.Log("Yet another debug");

        timeUntilNextScaleChange = timeForScaleChange;

        //currentCoroutine = StartCoroutine(ScaleAfterTimeRoutine());
    }

    private void Update()
    {
        // if (!scaleChanged)
        // {
        //     timeUntilNextScaleChange -= Time.deltaTime;
        //     if (timeUntilNextScaleChange <= 0)
        //     {
        //         scaleRandomRange *= 2;
        //         scaleChanged = true;
        //     }
        // }

        transform.Translate(Vector2.right * Time.deltaTime * 1f);
                transform.Rotate(Vector3.forward * Time.deltaTime * 20f);
 spriteRenderer.color = Random.ColorHSV();
      transform.localScale =
                    new Vector3(Random.Range(scaleRandomRange.x, scaleRandomRange.y), 
                        Random.Range(scaleRandomRange.x, scaleRandomRange.y),
                        Random.Range(scaleRandomRange.x, scaleRandomRange.y));
    }

    [ContextMenu("Stop All Coroutines")]
    private void StopCoroutinesOnThisObject()
    {
        StopAllCoroutines();
    }

    [ContextMenu("Stop Specific Coroutines")]
    private void StopSpecificCoroutineOnThisObject()
    {
        if(currentCoroutine != null)
            StopCoroutine(currentCoroutine);
    }
    
}
