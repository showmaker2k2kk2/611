using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZombieGun : EnemyBrain
{


    protected override void Attack()
    {
        throw new System.NotImplementedException();
    }

    //protected override Player targetAttack => GameManager.Intance.player;


    protected void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
       
    }
    protected  void Start()
    {

    }


    protected  void Update()
    {
      

        //    float Distanceshot = Vector3.Distance(player.transform.position, transform.position);

        ////    if (Distanceshot < shootattack)
        ////    {
        ////        Shoot(player.transform.position);
        ////    }

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

