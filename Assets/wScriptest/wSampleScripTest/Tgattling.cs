using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Tgattling :MonoBehaviour
{

    public int speed;

    public int soluongdan;

    public Transform pointshot;
    public ParticleSystem bullet;

    private bool isfire;
    public float fireRate = 0.1f; // Tần suất bắn (thời gian giữa các viên đạn)
    private float nextFire = 0.0f; // Thời gian bắn lần tiếp theo



    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shot();
        }
    }
    void shot()
    {
        

       ParticleSystem bulet = Instantiate(bullet, pointshot.transform.position, transform.rotation);
        Rigidbody rigidbody = bulet.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * speed);
        Destroy(bulet, 1);
       


    }    
}
