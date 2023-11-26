using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class characterAnimator : MonoBehaviour
{
    Animator anim;
    public enum Animation
    {
        walk,
        Attack,
        Dead,
        idle
        
    }
    public enum AttackType
    {
        shotGun,
        Gattling
    }    
    public Animator Ator
    {
        get
        {
            if (anim == null)
                anim = GetComponent<Animator>();
            return anim;
        }
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


}
