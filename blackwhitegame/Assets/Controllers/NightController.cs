using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightController : MonoBehaviour
{
    public GameObject Moon;
    public GameObject Platform;
    public GameObject Light;
    public bool active;

    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            Moon.SetActive(true);
            Platform.SetActive(true);
            Light.SetActive(true);
        }
        else
        {
            Moon.SetActive(false);
            Platform.SetActive(false);
            Light.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Q))
            active = !active;
    }
}
