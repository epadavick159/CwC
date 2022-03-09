using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //declaring all variables
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float range = 15.0f;
    public float forwardRange = 15.0f;
    public GameObject prefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //disables the user from falling off the left edge
        if(transform.position.x < -range)
        {
            transform.position = new Vector3(-range , transform.position.y, transform.position.z);
        }

        //diables the user from falling off the right edge
        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        
        //diables the user from progressing too far backward
        if (transform.position.z < -forwardRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -forwardRange);
        }

        //diables the user from pregressing to far forward
        if (transform.position.z > forwardRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, forwardRange);
        }

        //when the user pressed the space key, the food object will be launched forward
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, projectileSpawnPoint.position, prefab.transform.rotation);
        }
        //moves the character left or right depending on the use of a left or right arrow key
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput  * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    }
}
