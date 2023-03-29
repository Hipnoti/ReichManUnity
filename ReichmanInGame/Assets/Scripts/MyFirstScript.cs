using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Reichman!");
        Debug.Log("We are having fun!");
        Debug.Log("Yet another debug");
    }

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 1f);
                transform.Rotate(Vector3.forward * Time.deltaTime * 20f);
    }
}
