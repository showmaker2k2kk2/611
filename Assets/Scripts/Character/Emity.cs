﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Emity : MonoBehaviour// nhận dame,tan cong, animation ,die,agent
{
    protected NavMeshAgent agent;
    
   



    protected characterAnimator animator=null;
    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
     
        
    }

   
    void Update()
    {
        
    }
    
    protected virtual void Death() 
    {
        
    }

    

    
}
