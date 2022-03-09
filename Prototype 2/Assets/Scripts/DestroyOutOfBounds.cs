using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //declaring all used variables
    private float topRange = 30.0f;
    private float bottomRange = -10.0f;
    private float sideRange = 25.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //sets boundaries for character and animal spawns, as well as declares game over when an animal passes the player
        if(transform.position.z > topRange || transform.position.z <bottomRange || transform.position.x > sideRange || transform.position.x < -sideRange)
        {
            Destroy(gameObject);
            if(transform.position.z < bottomRange || transform.position.x > sideRange || transform.position.x < -sideRange)
            {
                Debug.Log("Game Over :(");
            }

        }
    }
}
