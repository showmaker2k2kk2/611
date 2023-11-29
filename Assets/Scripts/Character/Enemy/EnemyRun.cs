using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRun : EnemyBrain 
{
    characterAnimator chaAnimator;
    //protected override Player targetAttack => GameManager.Intance.player;// khi khoir taoj chir chayj 1 cai


    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Attack()
    {
        agent.isStopped = true;
        chaAnimator.SetAttack(characterAnimator.Attacktype.Mele);


    }    
}
