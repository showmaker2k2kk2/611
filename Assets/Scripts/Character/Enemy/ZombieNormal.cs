using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : EnemyBrain
{

    protected  Player targetAttack => GameManager.Intance.player;// khi khoir taoj chir chayj 1 cai
    private void Awake()
    {
       
        agent = GetComponent<NavMeshAgent>();

    }


       void Start()
      {
       
      }


     protected override void Update()
    {
        base.Update();
    }
 protected override void Attack()
    {
     // Debug.Log("")
    }


}
