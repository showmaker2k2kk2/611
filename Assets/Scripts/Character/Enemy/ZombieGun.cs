using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieGun : MonoBehaviour
{
    private float angularSpeed = 5;
    public float shootattack = 10;
    protected Enemy enemy;
    public GameObject player;
    
    public NavMeshAgent agent;
    private Animator anim;




    protected void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
    }
    protected  void Start()
    {

    }


    protected  void Update()
    {
      

            float Distanceshot = Vector3.Distance(player.transform.position, transform.position);

        //    if (Distanceshot < shootattack)
        //    {
        //        Shoot(player.transform.position);
        //    }

        //    else 
        //{
        //    enemy.Movewaypoint()
        //}
        enemy.Testso();

        }
        void Shoot(Vector3 target)
        {
            agent.isStopped = true;
            Vector3 dir = target - transform.position;
            anim.SetBool("shot", true);

        }

     
    }

