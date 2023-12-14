using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buletEnemy : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * moveSpeed);
          
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("danemeny");
        }
    }
}
