using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string name;

    bool active = true;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && active == true)
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                other.GetComponent<Player>().myInventory.Add(this.gameObject);
                active = false;
                transform.gameObject.SetActive(false);
            }
        }
    }
}
