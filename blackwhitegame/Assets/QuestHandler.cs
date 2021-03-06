﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestHandler : MonoBehaviour
{
    public Text questName;
    public Text questDescription;

    int currentStoryState;

    public GameManager gameManager;
    //public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentStoryState = GameManager.storyState;

        if (currentStoryState == 1)
        {
            questName.text = "Talk to Burger Boss";
            questDescription.text = "Go speak to Burger Boss, he's right in front of you!";
        }

        if (currentStoryState == 2)
        {
            questName.text = "Get some Coffee for Burger Boss";
            questDescription.text = "Go to the lunchroom and get some coffee from the coffee machine.";
        }
        
        if (currentStoryState == 3)
        {
            questName.text = "Find some coffee on level 2";
            questDescription.text = "The coffee machine in the lunchroom is busted. Use the elevator to go to level 2 and find another.";
        }
        
        if (currentStoryState == 4)
        {
            questName.text = "Bring Burger Boss some coffee";
            questDescription.text = "You finally found some coffee! Bring it back to your boss.";
        }
        
        if (currentStoryState == 5)
        {
            questName.text = "Vertical slice complete!";
            questDescription.text = "Well thats it. Feel free to explore.";
        }
    }

    
}
