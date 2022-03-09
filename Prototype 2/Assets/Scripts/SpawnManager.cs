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
        InvokeRepeating("SpawnForward", delay, spawnInterval);
        InvokeRepeating("RightSpawn", delay, spawnInterval);
        InvokeRepeating("LeftSpawn", delay, spawnInterval);
    }

    //random animal is generated at random point within the range provided on the x axis
    void SpawnForward()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 locationIndex = new Vector3(Random.Range(-15, 15), 0, 29);
        Instantiate(animalPrefabs[animalIndex], locationIndex, animalPrefabs[animalIndex].transform.rotation);
    }

    void RightSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rotate = new Vector3(0, -90, 0);
        Vector3 sideLocationIndex = new Vector3(25, 0, Random.Range(-10, 20));
        Instantiate(animalPrefabs[animalIndex], sideLocationIndex, Quaternion.Euler(rotate));

    }

    void LeftSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rotate = new Vector3(0, 90, 0);
        Vector3 sideLocationIndex = new Vector3(-25, 0, Random.Range(-10, 20));
        Instantiate(animalPrefabs[animalIndex], sideLocationIndex, Quaternion.Euler(rotate));
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
