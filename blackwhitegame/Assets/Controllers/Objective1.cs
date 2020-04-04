using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour
{
    public GameObject objective1;
    public GameObject objectivecomplete;

    public string objectiveName;

    void Start()
    {
        objective1.SetActive(false);
        objectivecomplete.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //enters collider without item, boss says item they want
        if (other.gameObject.CompareTag("Player"))
        {
            objective1.SetActive(true);
            if (other.gameObject.CompareTag("Player") && other.GetComponent<Player>().myInventory[0].name == objectiveName)
            {
                objective1.SetActive(false);
                objectivecomplete.SetActive(true);
            }
        }
        //enters collider with item, boss says they have item
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //exits collider without item
        if (other.gameObject.CompareTag("Player"))
        {
            objective1.SetActive(false);
        }
        //exits collider with item
        if (other.gameObject.CompareTag("Player") && other.GetComponent<Player>().myInventory[0].name == objectiveName)
        {
            objectivecomplete.SetActive(false);
        }
    }
}
