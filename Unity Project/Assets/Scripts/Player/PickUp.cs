using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public float pickUpRange = 5;
    public float moveForce = 250;

    //Adds holdParent to Hierarchy tab
    public Transform holdParent;
    //Stores GameObject as varable heldObj
    private GameObject heldObj;

    // Update is called once per frame
    void Update()
    {
     //if the E key is pressed
     if (Input.GetKeyDown(KeyCode.E) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */)
     {
       //if the held object is null
       if (heldObj == null)
       {

       //Find the posiition of object
       RaycastHit hit;

       //if position of the object is the RaycastHit change position to ObjectHolder next to player
       if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
       {
         PickupObject(hit.transform.gameObject);
       }
     }
     //if else drop held object
     else
     {
      DropObject();
     }
   }

     //checks if heldObj is null
     if (heldObj != null)
     {
        MoveObject();
     }
  }
      void MoveObject()
      {
        if (Vector3.Distance(heldObj.transform.position, holdParent.position) > 0.1f)
        {
           Vector3 moveDirection = (holdParent.position - heldObj.transform.position);
           heldObj.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);
        }
      }

       void PickupObject(GameObject pickObj)
       {
         if (pickObj.GetComponent<Rigidbody>())
         {
           Rigidbody objRig = pickObj.GetComponent<Rigidbody>();
           objRig.useGravity = false;
           objRig.drag = 10;

           objRig.transform.parent = holdParent;
           heldObj = pickObj;
         }
       }
       void DropObject()
       {
         Rigidbody heldRig = heldObj.GetComponent<Rigidbody>();
         heldRig.useGravity = true;
         heldRig.drag = 1;

         heldObj.transform.parent = null;
         heldObj = null;
       }
}
