using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declare global variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput = 0;
    private float forwardInput = 0;
    private byte userPressedUpBtn = 0;
    
    void Start()
    {
        // Define the intial value of this variable so that the car starts moving when it spawns
        userPressedUpBtn = 1;
    }

    void Update()
    {
        // Get the keyboard arrow values
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // If the user presses up, change the value of the var to know that the player pressed up
        if (forwardInput > 0f)
        {
            userPressedUpBtn = 1;
        }
        // If the user presses down, change the value of the var to know that the player pressed down
        else if (forwardInput < 0f)
        {
            userPressedUpBtn = 0;
        }
        
        // Use the given formula to move and rotate the car with the difference of multiplying it with the value of userPressedBtn
        // which will also be between 0 and 1 which will stop or move the car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * userPressedUpBtn);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput * userPressedUpBtn);
    }
}
