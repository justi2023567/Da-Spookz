using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
  // ALL THE SEWERS registater to spawn
  public GameObject sewerturn; //1
  public GameObject tsewer; //2
  public GameObject lturn; //3
  public GameObject straight; //4
  // the amount of sewers
  float counts = 10f;
  // the known lastsewr for proper builtage
  int lastsewer = 1;
  int sewerside ;
  int mutiside = 0; // check if the sewer need a another side.
  bool side1 = false; // this will check if the sewer side is full
  bool side2 = false;
  bool side3 = false;
  bool side4 = false;
  Quaternion lastrotation;
  Quaternion normalrotate;
  private Vector3 lastPosition;
  private Vector3 newpost;
  // show the stuff for new sewer
  GameObject newsewer;
    // Start is called before the first frame update
    void Start()
    {
      GameObject newsewer = Instantiate (sewerturn, new Vector3(0,20,0), Quaternion.Euler(0,0,0) ); // instantiate create a new block with ( object, postition, rotation) It Start the core of the generator
      lastPosition = newsewer.transform.position;
      lastrotation = newsewer.transform.rotation;
      normalrotate = newsewer.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      if( counts != 0 ) {
        counts -= 1;

        int sewerchoose = Random.Range(1,5);// pick a sewer
        // BUILDING T SEWERS ON X SEWERS
        if(sewerchoose == 2 & lastsewer == 1){ // do it depend on last sewer and current sewer for proper size
          do {

             sewerside = Random.Range(1,5); // pich a side

            if(sewerside == 1){ // if up is pick from up left down right
              mutiside = Random.Range(1,3);
              if (side1 == false) { // to make sure there is no sewer in the thing.
                side1 = true;
                newpost = lastPosition + new Vector3(18.5f,0f,0f); // get the new post for our sewer
                newsewer = Instantiate(tsewer, newpost, Quaternion.Euler(0,0,0));

                if (mutiside == 1) {

                  lastPosition = newsewer.transform.position;
                  lastrotation = newsewer.transform.rotation; // change the position of the last sewer
                }
              }
            }
            if(sewerside == 2){
              mutiside = Random.Range(1,3);
              if (side2 == false) {
                  side2 = true;
                newpost = lastPosition + new Vector3(-15.2f,0f,-41f); // left
                newsewer = Instantiate(tsewer, newpost, Quaternion.Euler(0,0,0));
                if (mutiside == 1) { // if there mutiside is does not count toward max sewer since it just one sewer hybrid

                  lastPosition = newsewer.transform.position;
                  lastrotation = newsewer.transform.rotation; // change the position of the last sewer
                }
              }
            }
            if(sewerside == 3){
              mutiside = Random.Range(1,3);
              if (side3 == false) {

                side3 = true;
                newpost  = lastPosition + new Vector3(-28.5f,0f,-23f); // down
                newsewer = Instantiate(tsewer, newpost, Quaternion.Euler(0,90,0));
                if (mutiside == 1) {

                  lastPosition = newsewer.transform.position;
                  lastrotation = newsewer.transform.rotation;
                  Debug.Log(lastrotation); // change the position of the last sewer
                }
              }
            }
            if(sewerside == 4){
              mutiside = Random.Range(1,3);
              if (side4 == false) {
                side4 = true;
                newpost = lastPosition + new Vector3(-15.2f,0f,41f); // right
                newsewer = Instantiate(tsewer, newpost, Quaternion.Euler(0,0,0));
                if (mutiside == 1) {

                  lastPosition = newsewer.transform.position;
                  lastrotation = newsewer.transform.rotation; // change the position of the last sewer
                }
              }
            }

          lastsewer = 2;
        } while (mutiside == 2);
         side1 = false;
         side2 = false;
         side3 = false;
         side4 = false;
         Debug.Log(sewerside + "side");
        if (sewerside == 1) {
          side1 = true;
        }
        if (sewerside == 2) {
          side2 = true;
        }
        if (sewerside == 3) {
          side3 = true;
        }
        if (sewerside == 4) {
          side4 = true;
        }
      }

       // BUILDING X SEWERS ON T SEWERS
      if(sewerchoose == 1 & lastsewer == 2 & lastrotation == normalrotate ){ // do it depend on last sewer and current sewer for proper size
        Debug.Log(side1);
        Debug.Log(side2);
        Debug.Log(side3);
        Debug.Log(side4);
        do {

           sewerside = Random.Range(1,4); // pich a side

          if(sewerside == 1){ // if up is pick from left down right
            mutiside = Random.Range(1,3);
            if (side4 == false) {

              newpost = lastPosition + new Vector3(15.2f,0f,40.9f); // get the new post for our sewer
              newsewer = Instantiate(sewerturn, newpost, Quaternion.Euler(0,0,0));

              if (mutiside == 1) {

                lastPosition = newsewer.transform.position; // change the position of the last sewer
              }
            }
          }
          if(sewerside == 2){
            mutiside = Random.Range(1,3);
            if (side1 == false) {

            }
            newpost = lastPosition + new Vector3(-18.5f,0f,0f); // down
            newsewer = Instantiate(sewerturn, newpost, Quaternion.Euler(0,0,0));
            if (mutiside == 1) { // if there mutiside is does not count toward max sewer since it just one sewer hybrid

              lastPosition = newsewer.transform.position; // change the position of the last sewer
            }
          }
          if(sewerside == 3){
            mutiside = Random.Range(1,3);
            if (side2 == false) {

              newpost  = lastPosition + new Vector3(15.2f,0f,-40.9f); // right
              newsewer = Instantiate(sewerturn, newpost, Quaternion.Euler(0,0,0));
              if (mutiside == 1) {

                lastPosition = newsewer.transform.position; // change the position of the last sewer
              }
            }
          }


        lastsewer = 1;
      } while (mutiside == 2);
      side1 = false;
      side2 = false;
      side3 = false;
      side4 = false;
     if (sewerside == 1) {
       side1 = true;
     }
     if (sewerside == 2) {
       side2 = true;
     }
     if (sewerside == 3) {
       side3 = true;
     }
     if (sewerside == 4) {
       side4 = true;
     }
    }



      }
    }
}
