//Emily Padavick
//March 15 2022
//GVR
//checks collisions between gameObjects and destroys both objects; also removes lives when error made (i.e. animal hits player)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private GameManager gameManager;
    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
            gameManager.AddLives(-1);
            
            Destroy(gameObject);
        }
        else if (other.CompareTag("food"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(food);
        }
       else
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        } 
    }
}
