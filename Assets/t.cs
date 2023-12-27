using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour
{
   public  GameObject Currentweapon;
    public Transform point;
    [SerializeField] private float speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shoot();
        }    
    }
    void shoot()
    {
      
        GameObject bullet = Instantiate(Currentweapon, point.transform.position, transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        //Destroy(bullet, 4);
    }
}
