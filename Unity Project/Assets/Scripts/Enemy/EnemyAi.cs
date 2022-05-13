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
  }
