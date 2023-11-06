using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Dame;
    [Header("Configuration")]
    public float moveSpeed;
    public float destroyAffterTime = 5f;

    Rigidbody rb;


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
        

    }
        
    private void OnTriggerEnter(Collider objectother)
    {
      

        ITakeDame dame = objectother.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(objectother.name);
        Destroy(gameObject);
        
    }
    
}
