using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */) {
          transform.Translate(Vector3.forward * Time.deltaTime * 20); // Time.deltaTime run at every 0.2 seconds and first agruement uses speed.
        }
        if (Input.GetKey(KeyCode.S) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */) {
          transform.Translate(Vector3.back * Time.deltaTime * 20); // Time.deltaTime run at every 0.2 seconds and first agruement uses speed.
        }
        if (Input.GetKey(KeyCode.D) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */) {
          transform.Translate(Vector3.right * Time.deltaTime * 20); // Time.deltaTime run at every 0.2 seconds and first agruement uses speed.
        }
        if (Input.GetKey(KeyCode.A) /* other function GetKey and GetKeyUp number on top are Alpha1-9 */) {
          transform.Translate(Vector3.left * Time.deltaTime * 20); // Time.deltaTime run at every 0.2 seconds and first agruement uses speed.
        }
    }
}
