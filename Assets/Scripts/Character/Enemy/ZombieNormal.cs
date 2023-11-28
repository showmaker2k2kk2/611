using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : EnemyBrain
{

    protected override Player targetAttack => GameManager.Intance.player;// khi khoir taoj chir chayj 1 cai
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
   public override void Attack()
    {

    }

}
