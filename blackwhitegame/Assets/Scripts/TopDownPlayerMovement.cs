using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownPlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public float distanceTravelled;

    public Vector2 playerPositionPrevious;
    public Vector2 playerPositionCurrent;

    public float battleTrigger;

    void Start()
    {
        transform.position = GameManager.overworldPos;

        playerPositionPrevious = transform.position;

        battleTrigger = Random.Range(5.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Escape))
            EditorApplication.isPlaying = false;
    }

    void PlayerMovement()
    {
        //movement
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    void DistanceCalculator()
    {
        float dist = Vector3.Distance(transform.position, playerPositionPrevious);

        distanceTravelled += dist;


        if (distanceTravelled >= battleTrigger)
        {
            GameManager.overworldPos = transform.position;
            SceneManager.LoadScene("Battle");

        }

        playerPositionPrevious = transform.position;

        
    }

    void FixedUpdate()
    {
        PlayerMovement();

        DistanceCalculator();
    }
}
