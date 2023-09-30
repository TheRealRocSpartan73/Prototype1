using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurret : MonoBehaviour
{
    // Start is called before the first frame update
    public float leftRotate = 20.0f;
    public float rightRotate = 20.0f;
    public float leftbutton;
    public float rightbutton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        leftbutton = Input.GetAxis("Fire1");
        rightbutton = Input.GetAxis("Fire2");
        transform.Rotate(Vector3.down, leftbutton * leftRotate * Time.deltaTime); 
        transform.Rotate(Vector3.up, rightbutton * rightRotate * Time.deltaTime);

    }
}
