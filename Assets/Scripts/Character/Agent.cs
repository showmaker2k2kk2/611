using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Agent : MonoBehaviour
{

    public NavMeshAgent agent;
    private Animator anim;
    private bool arride;
    private int currentpoint;
    


    private void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Moveplayer(Vector3 Target)
    {
        agent.isStopped= false;
        agent.SetDestination(Target);



    }
    private void MoveWaypoint()
    {

    }
  
}
