using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatform : MonoBehaviour
{
    public Vector3 resetPos;
    public GameObject player;

    void OnTriggerEnter (Collider Player)
    {

        player.transform.position = new Vector3(-3, -2, 0);
    }
}
