using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    private float propellorRotateRate = 801.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the propeller
        transform.Rotate(Vector3.forward, propellorRotateRate * Time.deltaTime);
    }
}
