using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class TestMove : MonoBehaviour
{

    NavMeshAgent agent;
    public float speed = 5;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(transform.position!=Vector3.zero)
        {
            MoveInput(dir);
        }    
    }
        void MoveInput(Vector3 dirMove)
        {
            agent.Move(dirMove * speed * Time.deltaTime);
        }
    
  


}
