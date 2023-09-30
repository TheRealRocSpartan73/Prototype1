using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    public float horizontalInput;
    public float verticalInput;

    private string hAxis = "Horizontal";
    private string vAxis = "Vertical";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(hAxis);
        verticalInput = Input.GetAxis(vAxis);
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
