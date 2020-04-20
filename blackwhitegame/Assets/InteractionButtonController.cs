using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionButtonController : MonoBehaviour
{
    public GameObject interractionButton;

    private void OnTriggerStay2D(Collider2D collision)
    {
        interractionButton.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interractionButton.gameObject.SetActive(false);

    }


}
