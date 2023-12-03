using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBrain : MonoBehaviour
{
    private bool arride;
    public NavMeshAgent agent;
    public Transform[] destinationwaypoint;
    public Action arride2 = null;
    private int currentpoint;
    public int attackRange;
    Animator anim;


    bool tamnhin;
    bool phamvitancong;
    [SerializeField]float phamvinhin;
    [SerializeField] float tamvitancong;


    public LayerMask playerMaskt;
        


    private int angularSpeed=10;
    public float speed;


    bool folllowerplayer=false;


    protected Player targetAttack => GameManager.Intance.player;


    protected Action Onarride;




    private void Awake()
    {
      
;  anim = GetComponent<Animator>();

    }
    void Start()
    {
   
        agent = GetComponent<NavMeshAgent>();
        arride2 = OnArride;
        MoveWaypoint();
    }


  protected virtual  void Update()
    {

        tamnhin = Physics.CheckSphere(transform.position, phamvinhin, playerMaskt);
        phamvitancong = Physics.CheckSphere(transform.position, tamvitancong, playerMaskt);

        if (!tamnhin && !phamvitancong) MoveWaypoint();
        if (tamnhin && !phamvitancong) followPlayer();
        if (tamnhin && phamvitancong) Attack();

        //float dirtotarget = Vector3.Distance(transform.position, targetAttack.transform.position);

            //if(dirtotarget<=10)
            //{
            //    folllowerplayer=true;
            //    //Attack();
            //    //agent.isStopped = true;
            //    rotationtotarget(targetAttack);
            //    return;
            //}
            //if(folllowerplayer&&dirtotarget >= 7)
            //{
            //    followPlayer();
            //}


            //if (Vector3.Distance(transform.position,targetAttack.transform.position)<=attackRange)
            //{
            //    agent.isStopped = true;
            //    Attack();
            //    return;

            //}
    }

    protected abstract void Attack();
   
    public void MoveWaypoint()
    {
        folllowerplayer = false;
        setDestination2(destinationwaypoint[currentpoint].position);
    }
    protected void setDestination2(Vector3 destination)
    {
        agent.isStopped = false;
        //  anim.SetBool("walk", true);
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= agent.radius)
        {
            arride2?.Invoke();
            //OnArride();
        }
    }
    public void OnArride()
    {
        arride = true;
        //anim.SetBool("walk", false);
        this.DelayCall(2, () =>
        {
            currentpoint++;
            if (currentpoint >= destinationwaypoint.Length)
                currentpoint = 0;
            arride = false;

        });
    }
    //public void RotateToDirection(Vector3 direction)  // xoay
    //{
    //    Quaternion targetQuaternion = Quaternion.LookRotation(direction, Vector3.up);
    //    transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, angularSpeed * Time.deltaTime);
    //}


    void rotationtotarget(Player target)
    {
        Vector3 dir = (target.transform.position - transform.position).normalized;
        Quaternion huong = Quaternion.LookRotation(dir, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, huong, agent.angularSpeed * Time.deltaTime);
    }
    
    void followPlayer()
    {
     
        agent.isStopped=false;
        agent.SetDestination(targetAttack.transform.position);
        



    }

  
    
    }
