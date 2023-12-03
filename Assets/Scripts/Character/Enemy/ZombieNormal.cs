using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieNormal : EnemyBrain, ITakeDame
{

    Animator Anim;
    BoxCollider box;
    public LayerMask playerMast;
    public Transform CheckPoint;
    



    protected Player targetAttack => GameManager.Intance.player;// khi khoir taoj chir chayj 1 cai
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
        float distanceFromPlayer2 = Vector3.Distance(transform.position, targetAttack.transform.position);
        base.Update();
    }
    //Collider a;
    //Player pl = a.gameObject.GetComponent<Player>();
    protected override void Attack()
    {
        Anim.SetTrigger("Attack");
        agent.SetDestination(transform.position);
        //Physics.OverlapBox()



    }
    void EnableAttack()
    {
        box.enabled = true;
    }
    void DisableAttack()
    {
        box.enabled = false;
    }
    public void AttackEvent()
    {
        //if (distanceFromPlayer2 <= 2)
        //{
        //    targetAttack.Takedame(2);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        //    var player=other.GetComponent<Player>();
        //    if (player != null) 
        //    {

        //    }
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawCube(CheckPoint.position, a);
    //}

    public void Takedame(int dame)
    {
        throw new System.NotImplementedException();
    }

}