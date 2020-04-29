using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionButtonController : MonoBehaviour
{
    public GameObject interractionButton;
    bool inCollider;

    private void Start()
    {
        interractionButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interractionButton.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interractionButton.gameObject.SetActive(false);
    }


}