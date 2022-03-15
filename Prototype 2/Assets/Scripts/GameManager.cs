//Emily Padavick
//March 15 2022
//GVR
//evaluates and displays the player's score and amount of lives left in the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //declaring variables
    private int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over :(");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
