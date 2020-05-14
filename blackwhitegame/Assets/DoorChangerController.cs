using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorChangerController : MonoBehaviour
{
    public List<GameObject> Doors;
    //public GameManager GameManagerObject;

    private void Start()
    {
        foreach (GameObject door in Doors)
            door.SetActive(false);
    }


    private void Update()
    {
        if (GameManager.storyState <= 3)
            Doors[0].SetActive(true);
        
        if (GameManager.storyState > 3)
            Doors[1].SetActive(true);
    }
}
