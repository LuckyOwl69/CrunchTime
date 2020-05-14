using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryStateSetter : MonoBehaviour
{

    public void Story1()
    {
        if (GameManager.storyState == 1) 
            GameManager.storyState = 2;
    }
    
    public void Story2()
    {
        if (GameManager.storyState == 2)
            GameManager.storyState = 3;
    }
    
    public void Story3()
    {
        if (GameManager.storyState == 3)
            GameManager.storyState = 4;
    }
    
    public void Story4()
    {
        if (GameManager.storyState == 4)
            GameManager.storyState = 5;
    }
}
