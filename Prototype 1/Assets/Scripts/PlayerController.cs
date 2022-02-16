using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // establishing private variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float forwardInput;
    private float horizontalInput;
    public Camera mainCamera;
    public Camera inCarCamera;
    public KeyCode switchKey;
    
    void Start()
    {
        
    }

    // Update is called once per sec
    void Update()
    {
        //getting user input
        horizontalInput = Input.GetAxis("Horizontal1");
        forwardInput = Input.GetAxis("Vertical1");
        
        //moves vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardInput);
        //rotates vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            inCarCamera.enabled = !inCarCamera.enabled;
        }
    }
}
