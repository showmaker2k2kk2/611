using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : Emity, ITakeDame
{
    public EnemyIndex indexEnemy;
    public int Dame;
    public int currenthealth;
    public int maxHealth = 100;
    public float speed;
    protected int attackrange;


    public NavMeshAgent AgentBody => this.TryGetMonoComponent(ref agent);
 
    public GameObject player;
    public Transform Target => GameManager.Intance.player.transform;
    public Transform[] destinationwaypoint;

    private int curentpoint;
    protected Animator anim;

    private Action den_noi;
    bool arride;

    public float rangedesti = 0.1f;
    protected bool isdeath = false;
    bool moveWaypoint;



    [SerializeField] LayerMask Player;
  
    bool lookplayer, AttackRange;

    protected void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        den_noi = OnArride;
    }
    protected override void Start()
    {
        base.Start();
        currenthealth = indexEnemy.StartHealth;
        curentpoint = 0;
        moveWaypoint = true;


     

    }

    bool isMoving;
   protected virtual void Update()
    {
        if (isdeath)
            return;

        if (!agent.pathPending && agent.remainingDistance < 0.1f && moveWaypoint)
        {
            Movewaypoint();

        }

        float Distantarget = Vector3.Distance(transform.position, player.transform.position);
        if(Distantarget<=2)
        {
            agent.isStopped = true;

            OnAttack();


        }    
        else if(Distantarget>2)
        {
         
        
        Lookplayer();

        }    



       
    }
    public void Takedame(int dame)
    {
        currenthealth -= dame;
        if (currenthealth <= 0)
        {
            Death();
        }
    }
    protected virtual void Movewaypoint()
    {
        isdeath = false;
        setDestination2(destinationwaypoint[curentpoint].position);

    }


    public void OnArride()
    {
        arride = true;
        anim.SetBool("walk", false);
        this.DelayCall(2, () =>
        {
            curentpoint++;
            if (curentpoint >= destinationwaypoint.Length)
                curentpoint = 0;
            arride = false;
        });
    }

    public void setDestination2(Vector3 destination)
    {
       
        agent.isStopped = false;
        anim.SetBool("walk", true);
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= AgentBody.radius)
        {
            OnArride();
        }
    }
    protected override void Death()
    {
        isdeath = true;
        anim.SetTrigger("Dead");
        anim.SetBool("walk", false);
        agent.isStopped = true;

    }
    //protected abstract void AttackMeelee();
    protected virtual void OnAttack()
    {

        agent.isStopped = true;
        anim.SetBool("walk", false);
        anim.SetBool("Attack", true);
        

    }
    void Lookplayer()
    {
        agent.isStopped = false;
        moveWaypoint = false;
        agent.SetDestination(player.transform.position);
        anim.SetBool("walk", true);
        anim.SetBool("Attack ", false);
    }
   
    

}