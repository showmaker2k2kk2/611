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
        
    }
    private void Awake()
    {
        anim= GetComponent<Animator>();
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


}
