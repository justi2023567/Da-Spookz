using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /* Allows use of scenes in code */

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Game"))
      {
         Cursor.visible = false; /* Can make cursor visible and invisible */
      }
      if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Main Menu"))
      {
        Cursor.visible = true; /* Can make cursor visible and invisible */
      }
    }
}
