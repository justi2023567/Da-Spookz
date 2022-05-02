using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    //Speed of player
    public float speed = 9f;
    //Player Gravity
    public float gravity = -9.81f;
    //Player Jump Height
    public float jumpHeight = 0.5f;

    //Checks The Rotation, Position And Scale of GroundCheck
    public Transform groundCheck;
    //The Distance Between Player And The Ground
    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
      {
      //Sprint
      if (Input.GetKey("left shift")){ //If Player Presses left Shift Key
	    speed = 12f; // Sprint Double Speed
      } else {
   	  speed = 9f; // Disable Sprint
      }

      isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

      if (isGrounded && velocity.y < 0)
      {
        velocity.y = -2f;
      }

      float x = Input.GetAxis("Horizontal"); /* Inputs movement with mouse and joystick */
      float z = Input.GetAxis("Vertical"); /* Inputs movement with mouse and joystick */

      Vector3 move = transform.right * x + transform.forward * z;

      controller.Move(move * speed * Time.deltaTime);

      if (Input.GetButtonDown("Jump") && isGrounded)
      {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
      }

      velocity.y += gravity * Time.deltaTime;

      controller.Move(velocity * Time.deltaTime);
    }
}
