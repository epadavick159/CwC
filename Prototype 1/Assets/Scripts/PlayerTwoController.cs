using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float forwardInput;
    private float horizontalInput;
    public Camera mainCameraTwo;
    public Camera inCarCameraTwo;
    public KeyCode switchKey;

    void Start()
    {

    }

    // Update is called once per sec
    void Update()
    {
        //getting user input
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");

        //moves vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCameraTwo.enabled = !mainCameraTwo.enabled;
            inCarCameraTwo.enabled = !inCarCameraTwo.enabled;
        }
    }
}
