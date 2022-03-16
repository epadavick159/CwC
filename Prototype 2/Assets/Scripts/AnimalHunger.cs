//Emily Padavick
//March 15 2022
//GVR
//measures and displays an animal gameObject's hunger scale - code from Carl

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    //declaring variables
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        Debug.Log(currentFedAmount);

        if(currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
