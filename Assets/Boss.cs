using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
   float CountTime;
   public float TimeRotate=3;


    Vector3 RotationAxis = Vector3.up;
    public float RotateAngle = 90;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountTime += Time.deltaTime;
        if(CountTime>=TimeRotate)
        {
            CountTime = 0;
            //Debug.Log("adumaaaan");
            Rotate();

        }    
    }
    private void Attack1()//laze
    {
        
    }
    void Attack2()
    {

    }
    void Attack3()
    {

    }
    void Rotate()
    {
        transform.Rotate(RotationAxis, RotateAngle);
    }

}
