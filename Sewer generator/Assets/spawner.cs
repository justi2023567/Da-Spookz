using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
  // ALL THE SEWERS registater to spawn
  public GameObject sewerturn;
  public GameObject tsewer;
  public GameObject lturn;
  public GameObject straight;
  // the amount of sewers
  float counts = 10f;
  //
  int lastsewer = 1;
  private Vector3 lastPosition;
  // show the stuff for new sewer
  GameObject newsewer;
    // Start is called before the first frame update
    void Start()
    {
      GameObject newsewer = Instantiate (sewerturn, new Vector3(0,20,0), Quaternion.Euler(0,0,0) );
      lastPosition = newsewer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      if( counts != 0 ) {
        counts -= 1;

        int sewerchoose = Random.Range(1,5);// pick a sewer
        if(sewerchoose == 2 & lastsewer == 1){ // do it depend on last sewer and current sewer for proper size
        int sewerside = Random.Range(1,5); // pich a side
        Debug.Log(sewerchoose);
        Debug.Log(sewerside);
        if(sewerside == 1){
             lastPosition = lastPosition + new Vector3(18.5f,0f,0f);
        newsewer = Instantiate(sewerturn, lastPosition, Quaternion.Euler(0,0,0));
          lastPosition = newsewer.transform.position;
        }
        if(sewerside == 2){
          lastPosition = lastPosition + new Vector3(-15.2f,0f,-41f);
     newsewer = Instantiate(sewerturn, lastPosition, Quaternion.Euler(0,0,0));
        lastPosition = newsewer.transform.position;
        }
        if(sewerside == 3){
          lastPosition = lastPosition + new Vector3(-28.5f,0f,-23f);
     newsewer = Instantiate(sewerturn, lastPosition, Quaternion.Euler(0,90,0));
      lastPosition = newsewer.transform.position;
        }
        if(sewerside == 4){
          lastPosition = lastPosition + new Vector3(15.2f,0f,41f);
     newsewer = Instantiate(sewerturn, lastPosition, Quaternion.Euler(0,0,0));
      lastPosition = newsewer.transform.position;
        }
      }
      }
    }
}
