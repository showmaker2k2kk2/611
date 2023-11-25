using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : EnemyBrain
{
  

    private void Awake()
    {
       
        agent = GetComponent<NavMeshAgent>();

    }


       void Start()
      {
       
      }


     void Update()
    {
        
    }
    

}
