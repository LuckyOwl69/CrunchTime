using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayController : MonoBehaviour
{
    public GameObject Sun;
    public GameObject Platform;
    public GameObject Shadow;
    public bool active;

    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            Sun.SetActive(true);
            Platform.SetActive(true);
            Shadow.SetActive(true);
        }
        else
        {
            Sun.SetActive(false);
            Platform.SetActive(false);
            Shadow.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Q))
            active = !active;
    }
}
