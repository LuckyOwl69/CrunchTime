using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static Vector3 overworldPos;

    public float overworldPosX;
    public float overworldPosY;

    

    //public BattleSystem BattleSystemObject;

    public float PlayerHealth;

    //bool madeCoffee = false;

    public static int storyState = 1;
    //public int currentStoryState = 1;


    void Start()
    {
        //storyState = GameManager.instance.storyState;
    }

    void Update()
    {
        //storyState = currentStoryState;


    }

    public void StoryState2()
    {
        if (storyState == 1)
            storyState = 2;
            //currentStoryState = 2;
    }

    public void StoryState3()
    {
        if (storyState == 2)
            storyState = 3;
            //currentStoryState = 3;
    }
    
    public void StoryState4()
    {
        if (storyState == 3)
            storyState = 4;
            //currentStoryState = 3;
    }
    
    public void StoryState5()
    {
        if (storyState == 4)
            storyState = 5;
            //currentStoryState = 3;
    }




    void Awake()
    {


        if (instance == null)
        {
            //storyState = currentStoryState;

            overworldPos.x = overworldPosX;
            overworldPos.y = overworldPosY;
            //questName = GameManager.instance.questName;
            //storyState = GameManager.instance.storyState;
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            
        }
        else
        {
            Destroy(this.gameObject);
            //questName = GameManager.instance.questName;

        }


    }

    
}
