using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieGun : Enemy, ITakeDame
{
    private float angularSpeed = 5;
    public float shootattack = 10;
    protected Enemy enemy;
    //NavMeshAgent agent;



    protected void Awake()
    {
       //agent= GetComponent<NavMeshAgent>();
    }
    protected override void Start()
    {

    }


    protected override void Update()
    {
       base.Update();
        if (isdeath)
            return;
        Debug.Log("22222aaa");
        Test();

        if (!agent.pathPending && agent.remainingDistance < 0.1f && moveWaypoint)
        {
           enemy.Movewaypoint();
            Debug.Log("1111aaa");

        //}   
        setDestination2(destinationwaypoint[curentpoint].position);

        float Distanceshot = Vector3.Distance(player.transform.position, transform.position);

      if(Distanceshot<shootattack)
        {
            Shoot(player.transform.position);
        }

    }
    void Shoot(Vector3 target)
    {
        agent.isStopped = true;
        Vector3 dir= target-transform.position;
        anim.SetBool("shot", true);

    }


  
}
