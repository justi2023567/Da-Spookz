using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 7f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
      {
      if (Input.GetKey("left shift")){ // If Player Presses Shift Key
	    speed = 11f; // Sprint Double Speed
      } else {
   	  speed = 7f; // Disable Sprint
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
