using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Agent : MonoBehaviour
{

    public NavMeshAgent agent;
    private Animator anim;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void Moveplayer(Vector3 Target)
    //{
    //    agent.isStopped= false;
    //    agent.SetDestination(Target);



    //}
    //private void MoveWaypoint()
    //{

    //}
    //public void MoveWaypoint()
    //{
    //    setDestination2(destinationwaypoint[currentpoint].position);
    //}
    //protected void setDestination2(Vector3 destination)
    //{
    //    agent.isStopped = false;
    //    //  anim.SetBool("walk", true);
    //    agent.SetDestination(destination);
    //    if (Vector3.Distance(transform.position, destination) <= agent.radius)
    //    {
    //        arride2?.Invoke();
    //        //OnArride();
    //    }
    //}
    //public void OnArride()
    //{
    //    arride = true;
    //    //anim.SetBool("walk", false);
    //    this.DelayCall(2, () =>
    //    {
    //        currentpoint++;
    //        if (currentpoint >= destinationwaypoint.Length)
    //            currentpoint = 0;
    //        arride = false;

    //    });
    //}
    //public void RotateToDirection(Vector3 direction)  ////////////////////
    //{
    //    Quaternion targetQuaternion = Quaternion.LookRotation(direction, Vector3.up);
    //    transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, angularSpeed * Time.deltaTime);
    //}

}
