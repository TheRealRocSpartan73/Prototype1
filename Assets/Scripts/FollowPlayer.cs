using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 cameraOffset = new Vector3(1, 11, -19);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset camera behnd players postion.
        transform.position = player.transform.position + cameraOffset;
        
    }
}
