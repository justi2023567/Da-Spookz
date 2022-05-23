using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject enemy;
    public Transform aiming;
    public GameObject checks; // grab variables from the main camera aka need the pick up script
    public GameObject gun; // grabs the gun GameObject for checking.
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // Grab the Hand object from the pick up script
      GameObject Hand = checks.GetComponent<PickUp>().heldObj;
      GameObject Hand2 = checks.GetComponent<PickUp>().heldObj2;
      //check each Held Object with the gun object
      if ( Hand == gun || Hand2 == gun){
      // target anything in layer 3
      int layerMask = 1 << 3;
    // grab the position of the player and face it fowards.
      Vector3 forward = aiming.TransformDirection(Vector3.forward);
      // draw a invisble line of dection
        if(Physics.Raycast(aiming.position, forward, 10, layerMask )){
          Debug.Log("enemy coming");
          if (Input.GetKeyDown(KeyCode.Q)) {
            // find a fancy way for enemy death instead of thanos snap.
            Destroy(enemy.GetComponent<CapsuleCollider>());
            Destroy(enemy.GetComponent<EnemyAi>().agent);

          }
        }
      }
    }
}
