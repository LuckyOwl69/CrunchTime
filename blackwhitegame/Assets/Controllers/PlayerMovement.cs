using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 400f;

    float horiMove = 0f;

    bool jumped = false;

    // Update is called once per frame
    void Update()
    {
        horiMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jumped = true;
        }
    }

    void FixedUpdate ()
    {
        //move our character
        controller.Move(horiMove * Time.fixedDeltaTime, false, jumped);
        jumped = false;
    }
}
