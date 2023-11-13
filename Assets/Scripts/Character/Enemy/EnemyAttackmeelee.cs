using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackmeelee : Enemy
{
    public float AttacRange;
    private Animator anim;
    private NavMeshAgent agent;

    private void Awake()
    {
        //anim = GetComponent<Animator>();
        //agent = GetComponent<NavMeshAgent>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Attack()
    {
        anim.SetBool("walk", false);
        agent.isStopped = true;
    }
}