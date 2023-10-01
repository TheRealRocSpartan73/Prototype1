using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2RotateTurrent : MonoBehaviour
{
    // Start is called before the first frame update
    public float leftRotate = 20.0f;
    public float rightRotate = 20.0f;
    public float leftTurretRotate;
    public float rightTurretRotate;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Get turret left rotate from "q" button or turret rotate right from "e" button
        leftTurretRotate = Input.GetAxis("TurretLeftP2");
        rightTurretRotate = Input.GetAxis("TurretRightP2");

        //Rotate turret based on keyboard input
        transform.Rotate(Vector3.down, leftTurretRotate * leftRotate * Time.deltaTime);
        transform.Rotate(Vector3.up, rightTurretRotate * rightRotate * Time.deltaTime);

    }
}
