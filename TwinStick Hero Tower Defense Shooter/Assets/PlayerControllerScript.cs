using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    // We have access to the player's rigidbody for movement & camera for rotation
    private Rigidbody rb;
    private Camera gameCamera;
    // speed at which the player will be moving
    public float playerSpeed;
    // point where the bullet spawns
    public Transform bulletPoint;
    public BulletControllerScript bullet;

	// Use this for initialization
	void Start ()
    {
        // Get access to the player's rigid body
        rb = GetComponent<Rigidbody>();
        // Get access to the game camera
        gameCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}

    void Update()
    {
        // Handling the rotation of the player
        Ray rotationRay = gameCamera.ScreenPointToRay(Input.mousePosition); // Getting the mouse position
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float raylength;

        if (plane.Raycast(rotationRay, out raylength))
        {
            // Getting the position of the mouse cursor
            Vector3 cursorLocation = rotationRay.GetPoint(raylength);

            // Debug to see the raycast
            Debug.DrawLine(rotationRay.origin, cursorLocation, Color.red);

            // Now we rotate towards the mouse position
            transform.LookAt(new Vector3(cursorLocation.x, transform.position.y, cursorLocation.z));
        }

        // If the left button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        }
    }

    // This update is used for physics movement with forces
    void FixedUpdate ()
    {
        // Getting the axis values for X & Z movement
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        // Making the vector that'll be used for movement
        Vector3 movement = new Vector3(xMovement, 0, zMovement);    // Y is 0 due to no jumping (as of now)

        // Now, we add the movement vector to our rigidbody
        rb.AddForce(movement * playerSpeed);
    }
}