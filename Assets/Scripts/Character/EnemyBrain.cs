using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBrain : MonoBehaviour
{
    private bool arride;
    private int currentpoint;
    private Transform []destinationwaypoint;
    public NavMeshAgent agent;
    [SerializeField] protected Agent _agent;


    protected Action Onarride;




    private void Awake()
    {
      
;

    }
    void Start()
    {
        Onarride = OnArride;
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

    }
    public void MoveWaypoint()
    {
        setDestination2(destinationwaypoint[currentpoint].position);
    }
    protected void setDestination2(Vector3 destination)
    {
        agent.isStopped = false;
      //  anim.SetBool("walk", true);
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= agent.radius)
        {
            OnArride();
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
    public virtual void Attack(GameObject target)
    {

    }

    
    

}
