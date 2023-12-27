using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBounc : MonoBehaviour
{
    [SerializeField] private Rigidbody rbbulet;
    public int  NumberOfbounc = 3;

    private Vector3 Direc;
    private Vector3 lastVelocity;
    public float curentsped=100;
    private int curentBounc = 0;


        


    
    void LateUpdate()
    {
        lastVelocity = rbbulet.velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (curentBounc > NumberOfbounc) return;
        //curentsped = lastVelocity.magnitude;
        Direc = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        //rbbulet.velocity = Direc * curentsped;  
        rbbulet.AddForce(transform.forward * curentsped);   
        curentBounc++;
    }
}
