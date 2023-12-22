using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Transform center; 

    public float rotationSpeed = 20.0f; 

    void Update()
    {
        
        if (center != null)
        {
           
            transform.RotateAround(center.position, Vector3.up, rotationSpeed * Time.deltaTime);
            return;
        }

     

    }
}
