using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //declaring all variables
    public float horizontalInput;
    public float speed = 10.0f;
    public float range = 15.0f;
    public GameObject prefab;

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

        //when the user pressed the space key, the food object will be launched forward
        if (Input.GetKeyDown(KeyCode.Space))
        {
  
            Instantiate(prefab, transform.position, prefab.transform.rotation);
        }
        //moves the character left or right depending on the use of a left or right arrow key
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

    }
}
