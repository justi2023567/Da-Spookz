using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    float timer = 0;
     public float lookRadius = 10f;
     public GameObject health;
     Transform target;
     NavMeshAgent agent;

     void Start()
     {
       target = PlayerManager.instance.player.transform;
       agent = GetComponent<NavMeshAgent>();
     }

     void Update()
     {
       timer += Time.deltaTime;
       float distance = Vector3.Distance(target.position, transform.position);

       if (distance <= lookRadius)
       {
         agent.SetDestination(target.position);

         if (distance <= agent.stoppingDistance && timer >= 0.75f)
         {
           health.GetComponent<PlayerHealth>().TakeDamage(4); // the number in take
           timer = 0;
         }
      }
    }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD

    void FaceTarget()
    {
      Vector3 direction = (target.position - transform.position).normalized;
      Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
      transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

     void OnDrawGizmosSelected()
     {
       Gizmos.color = Color.red;
       Gizmos.DrawWireSphere(transform.position, lookRadius);
     }

}
=======
>>>>>>> Stashed changes
  }
>>>>>>> bad7c187c9ecd5243bf4c3b87597726895f9b9c2
