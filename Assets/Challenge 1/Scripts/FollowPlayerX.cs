using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 cameraOffset = new Vector3(21, 2, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //Use LateUpdate for smoother animation
    void LateUpdate()
    {
        //Move the camera as plane moves
        transform.position = plane.transform.position + cameraOffset;
    }
}
