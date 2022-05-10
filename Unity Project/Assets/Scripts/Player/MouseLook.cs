using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

  public float mouseSensitivity = 200f;
  //Adds playerBody to Hierarchy tab
  public Transform playerBody;

  float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
         //Keeps the cursor in a locked state
         Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);

      transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
      playerBody.Rotate(Vector3.up * mouseX);
    }
  }
