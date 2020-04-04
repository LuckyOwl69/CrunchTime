using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupIcon : MonoBehaviour
{
    public GameObject pickupicon;

    void Start()
    {
        pickupicon.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickupicon.SetActive(true);
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickupicon.SetActive(false);
        }
    }
}
