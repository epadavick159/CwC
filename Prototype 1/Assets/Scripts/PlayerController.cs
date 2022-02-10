using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per sec
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //We'll move the vehicle forward 
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
