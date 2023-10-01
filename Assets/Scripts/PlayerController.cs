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
    public string inputID;

    public Camera mainCamera;
    public Camera altCamera;
    public KeyCode cameraSwitchKey;

    private string hAxis = "Horizontal";
    private string vAxis = "Vertical";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from user
        horizontalInput = Input.GetAxis(hAxis + inputID);
        verticalInput = Input.GetAxis(vAxis + inputID);

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //Turn Vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //If Camera switch key is pressed, reverse the "enabled" status of eac camera, so one 
        //will always be enabled and the other "disabled".
        if(Input.GetKeyDown(cameraSwitchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            altCamera.enabled = !altCamera.enabled;


        }

    }
}
