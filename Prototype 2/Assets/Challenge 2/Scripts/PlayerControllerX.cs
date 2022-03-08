using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawn = 0.0f;
    private float delay = 1.0f;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > delay+lastSpawn)
        {
            lastSpawn = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
   
}
