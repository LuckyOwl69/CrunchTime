﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericDoorController : MonoBehaviour
{
    public string NextScene;
    public GameManager GameManagerObject;

    public float NextScenePositionX;
    public float NextScenePositionY;

    int currentStoryState;

    void Update()
    {
        currentStoryState = GameManager.storyState;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(NextScene);
            //SceneManager.LoadScene('"' + NextScene.name + '"');

            GameManager.overworldPos.x = NextScenePositionX;
            GameManager.overworldPos.y = NextScenePositionY;

            GameManager.storyState = currentStoryState;
        }
    }
}
