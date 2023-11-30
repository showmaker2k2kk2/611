using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : EnemyBrain
{

    Animator Anim;
    BoxCollider box;

    protected  Player targetAttack => GameManager.Intance.player;// khi khoir taoj chir chayj 1 cai
    private void Awake()
    {
       
        agent = GetComponent<NavMeshAgent>();
        box = GetComponentInChildren<BoxCollider>();
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
        Anim.SetTrigger("Attack");
        agent.SetDestination(transform.position);

    }
    void EnableAttack()
    {
        box.enabled = true;
    }    
    void DisableAttack()
    {
        box.enabled &= false;
    }
    private void OnTriggerEnter(Collider other)
    {
        var player=other.GetComponent<Player>();
        if (player != null) 
        {

        }
    }

}
