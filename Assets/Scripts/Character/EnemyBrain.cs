using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBrain : MonoBehaviour
{
    private bool arride;
    public NavMeshAgent agent;
    [SerializeField] protected Agent _agent;


    protected Action Onarride;




    private void Awake()
    {
      
;

    }
    void Start()
    {
   
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

    }
 
    public virtual void Attack(GameObject target)
    {

    }

    
    

}
