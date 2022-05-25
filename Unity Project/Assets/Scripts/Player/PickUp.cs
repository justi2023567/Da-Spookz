using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public float pickUpRange = 5;
    public float moveForce = 250;

    //Adds holdParent to Hierarchy tab. one per hand
    public Transform holdParent;
    public Transform holdParent2;
    //Stores GameObject as varable heldObj. one per hand
    public GameObject heldObj;
    public GameObject heldObj2;

    private GameObject swap;
    private Vector3 scale;
    // Update is called once per frame
    void Update()
    {
     //if the F key is pressed
     if (Input.GetKeyDown(KeyCode.Q) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */)
     {
       //if the held object is null
       if (heldObj == null)
       {

       //Find the posiition of object
       RaycastHit hit;

       //if position of the object is the RaycastHit change position to ObjectHolder next to player
       if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
       {
         //Get it pickObj
         scale = hit.transform.localScale;
         PickupObject(hit.transform.gameObject);
       }
     }
     //if else drop held object
     else
     {

      DropObject();
     }
   }

     //checks if heldObj is Not Empty
     if (heldObj != null)
     {
        MoveObject();
     }
     // also check the second hand.
     if (heldObj2 != null)
     {
        MoveObject2();
     }


  }
  //Move the object to the hand aka ObjectHolder
      void MoveObject()
      {
        if (Vector3.Distance(heldObj.transform.position, holdParent.position) > 0.1f)
        {
           Vector3 moveDirection = (holdParent.position - heldObj.transform.position);
           heldObj.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);
           heldObj.transform.localScale = scale;
        }
      }
      // almost the same. just a two after it for it second hand to work
      void MoveObject2()
      {
        if (Vector3.Distance(heldObj2.transform.position, holdParent2.position) > 0.1f)
        {
           Vector3 moveDirection = (holdParent2.position - heldObj2.transform.position);
           heldObj2.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);

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
         heldObj.transform.localScale = scale;
         heldObj = null;
       }



}
