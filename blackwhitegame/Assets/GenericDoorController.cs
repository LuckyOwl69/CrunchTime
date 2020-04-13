using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericDoorController : MonoBehaviour
{
    public Object NextScene;
    public GameManager GameManagerObject;

    public float NextScenePositionX;
    public float NextScenePositionY;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManagerObject.overworldPos.x = NextScenePositionX;
            GameManagerObject.overworldPos.y = NextScenePositionY;
            SceneManager.LoadScene(NextScene.name);
        }
    }
}
