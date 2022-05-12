using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject enemy;
    public Transform aiming;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      int layerMask = 1 << 3;
      //layerMask = ~layerMask;
      Vector3 forward = aiming.TransformDirection(Vector3.forward);
        if(Physics.Raycast(aiming.position, forward, 10, layerMask )){
          Debug.Log("enemy coming");
          if (Input.GetKeyDown(KeyCode.Q)) {
            Destroy(enemy);
          }
        }
    }
}
