using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 16.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves non-player car towards player
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
