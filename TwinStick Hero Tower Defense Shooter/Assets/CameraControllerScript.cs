using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    // We need a reference to the player
    private GameObject player;
    private Vector3 cameraOffset;

    // Use this for initialization
    void Start()
    {
        // Getting the player
        player = GameObject.FindGameObjectWithTag("Player");
        // Finding the offset between the player & the camera
        cameraOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame after all other update calls get called
    void LateUpdate()
    {
        // Updating the camera's location
        //transform.position = player.transform.position + cameraOffset;
    }
}
