//Emily Padavick
//March 15 2022
//GVR
//removes a GameObject when it goes out of the desegnated boundary of the gameview

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //declaring all used variables
    private float topRange = 30.0f;
    private float bottomRange = -10.0f;
    private float sideRange = 25.0f;
    private GameManager gameManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
                gameManager.AddLives(-1);
                Destroy(gameObject);
            }

        }
    }
}
