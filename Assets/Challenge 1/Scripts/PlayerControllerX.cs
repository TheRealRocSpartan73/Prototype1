using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float maxSpeed = 10.0f;  //forward speed of plane
    private float tiltSpeed = 100.0f; //plane tilt rate
    public float verticalInput;    //Capture input from up/down keys

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * maxSpeed);

        // get the user's vertical input from up/down arrows
        verticalInput = Input.GetAxis("Vertical");
        
        //Only tilt up or down if there is actual input. If 0 is return it means a key was not pressed.
        if (verticalInput != 0)
        {
            //tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right, Time.deltaTime * verticalInput * tiltSpeed);
        }
     

    }
}
