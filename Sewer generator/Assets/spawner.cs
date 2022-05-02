using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
  public GameObject sewerturn;
  public GameObject tsewer;
  public GameObject lturn;
  public GameObject straight;
  float counts = 10f;
  int lastsewer = 1;
  private Vector3 lastPosition;
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
        Debug.Log(counts);
        int sewerchoose = Random.Range(1,5);
        if(sewerchoose == 2 & lastsewer == 1){
        int sewerside = Random.Range(1,5);


        if(sewerside == 1){
             lastPosition = lastPosition + new Vector3(18.5f,0f,0f);
          Instantiate(sewerturn, lastPosition, Quaternion.Euler(0,0,0));
        }
        if(sewerside == 2){

        }
        if(sewerside == 3){

        }
        if(sewerside == 4){

        }
      }
      }
    }
}
