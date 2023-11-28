using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBrain : MonoBehaviour
{
    private bool arride;
    public NavMeshAgent agent;
    public Transform[] destinationwaypoint;
    public Action arride2 = null;
    private int currentpoint;
    private int angularSpeed;
    public int attackRange;

    protected abstract Player targetAttack { get; }

    protected Action Onarride;




    private void Awake()
    {
      
;

    }
    void Start()
    {
   
        agent = GetComponent<NavMeshAgent>();
        arride2 = OnArride;
    }


    void Update()
    {
     
            if(Vector3.Distance(transform.position,targetAttack.transform.position)<=attackRange)
        {
            agent.isStopped = true;
            Attack();
            return;

        }
    }
 
    public virtual void Attack()
    {

    }
    //public void MoveWaypoint()
    //{
    //    setDestination2(destinationwaypoint[currentpoint].position);
    //}
    protected void setDestination2(Vector3 destination)
    {
        agent.isStopped = false;
        //  anim.SetBool("walk", true);
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= agent.radius)
        {
            arride2?.Invoke();
            //OnArride();
        }
    }
    public void OnArride()
    {
        arride = true;
        //anim.SetBool("walk", false);
        this.DelayCall(2, () =>
        {
            currentpoint++;
            if (currentpoint >= destinationwaypoint.Length)
                currentpoint = 0;
            arride = false;

        });
    }
    public void RotateToDirection(Vector3 direction)  // xoay
    {
        Quaternion targetQuaternion = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, angularSpeed * Time.deltaTime);
    }





}
