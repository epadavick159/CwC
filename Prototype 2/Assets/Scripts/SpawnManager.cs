using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //declaring all used variables
    public GameObject[] animalPrefabs;
    public float delay = 2.0f;
    public float spawnInterval = 2.4f;
    
    // Start is called before the first frame update
    void Start()
    {
        //calls spawn method every spawnInterval seconds
        InvokeRepeating("Spawn", delay, spawnInterval);
    }

    //random animal is generated at random point within the range provided on the x axis
    void Spawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 locationIndex = new Vector3(Random.Range(-15, 15), 0, 29);
        Instantiate(animalPrefabs[animalIndex], locationIndex, animalPrefabs[animalIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
