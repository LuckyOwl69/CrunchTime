using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIcon : MonoBehaviour
{
    public GameObject dooricon;

    void Start()
    {
        dooricon.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dooricon.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dooricon.SetActive(false);
        }
    }
}
