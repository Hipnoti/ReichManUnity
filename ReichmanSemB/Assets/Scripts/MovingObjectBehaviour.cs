using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the start of the MovingObject script");
    }

    // Update is called once per frame
    void Update()
    {
        bool isForwardPressed = Input.GetKey(KeyCode.W);
        if (isForwardPressed == true)
        {
            transform.Translate(new Vector3(0, 0, 1) * (Time.deltaTime * 10));
        }
    }
}
