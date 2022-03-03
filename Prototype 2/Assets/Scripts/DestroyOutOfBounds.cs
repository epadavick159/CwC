using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topRange = 30.0f;
    private float bottomRange = -10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topRange || transform.position.z <bottomRange)
        {
            Destroy(gameObject);
        }
    }
}
