using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : Enemy
{
    public float AttacRange;
    private Animator anim;
    private NavMeshAgent agent;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }


       void Start()
      {
       
      }


 void Update()
    {
        
    }
    private void AttackMelee()
    {
        anim.SetBool("walk", false);
        agent.isStopped = true;

    }
    private void AttackGun()
    {  
    
    }

}
