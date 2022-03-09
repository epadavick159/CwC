using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when two objects collide, they will destroy each other (food and animal)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over :(");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
