using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieGun : EnemyBrain
{

   
    public GameObject projectilenemyGun;    
    public Transform Point;
    Animator anim;


 


    protected override void Attack()
    {
        anim.SetBool("Attack", true);

        GameObject bullet = Instantiate(projectilenemyGun, Point.transform.position, transform.rotation);
        Bullet bu = bullet.GetComponent<Bullet>();
     
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        //bu.Adfore();
        Destroy(bullet, 4);
    }

    //protected override Player targetAttack => GameManager.Intance.player;


    protected void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    protected  void Start()
    {

    }


    protected override void Update()
    {

        //base.Update();
        float Distanceshot = Vector3.Distance(targetAttack.transform.position, transform.position);

        if (Distanceshot < 15)
        {
            rotationtotarget(targetAttack);
           
            Attack();
          
        }

        ////    else 
        ////{
        ////    enemy.Movewaypoint()
        ////}
        ////enemy.Testso();
        //if (Distanceshot <=5)
        //{
        //    Move(player.transform.position);
        //}
        //else
        //{
        //    anim.SetBool(AnimationName.walk.ToString(), false);
        //}


    }
    //void Shoot(Vector3 target)
    //{
    //    agent.isStopped = true;
    //    Vector3 dir = target - transform.position;
    //    anim.SetBool("Attack", true);


    //}
    //void Attackplayer()
    //{
    //    GameObject BU = Instantiate(buletEnemy, pointshot1.transform.position, transform.rotation);
    //    Rigidbody rbu = BU.GetComponent<Rigidbody>();

    //}

    //void Move(Vector3 target)
    //{
    //    Rotationtarget(target);
    //    agent.SetDestination(target);
    //    anim.SetBool(AnimationName.walk.ToString(), true);

    //}

    //public enum AnimationName
    //{
    //    walk,   
    //    Attack,
    //    Dead

    //}
    //public void Rotationtarget(Vector3 target)
    //{
    //    Quaternion Dir = Quaternion.LookRotation(target);
    //    transform.rotation = Quaternion.Slerp(transform.rotation, Dir, angularSpeed );

    //}


}

