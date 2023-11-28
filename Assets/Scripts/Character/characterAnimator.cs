using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class characterAnimator : MonoBehaviour
{
    Animator anim;
    public enum AnimationState { Movement, Attack}
    public enum Movementype { idle,walk}
    public enum Attacktype { Shotgun, Gattling , Bazoka, Mele }


    public AnimationState CurrentAnimation;
    public Movementype CurrentMovementtype;
    public Attacktype CurrentAttack;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void SetMovement(Movementype type)
    {
        if (CurrentAnimation == AnimationState.Movement && CurrentMovementtype == type)
            return;
        anim.SetFloat("Movementtype", (int)type);
        anim.SetTrigger("Movement");
        CurrentAnimation = AnimationState.Movement;
        CurrentMovementtype = type;
        
    }
    public void SetAttack(Attacktype type)
    {
        if (CurrentAnimation == AnimationState.Attack && CurrentAttack == type)
            return;
        anim.SetFloat("Attacktype", (int)type);
        anim.SetTrigger("ATtack");
        CurrentAnimation = AnimationState.Movement;
        CurrentAttack = type;
    }

}
