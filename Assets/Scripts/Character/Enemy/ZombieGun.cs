using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieGun : Enemy, ITakeDame
{
    private float angularSpeed = 5;
    public float shootattack=10;


    protected void Awake()
    {

    }
    protected override void Start()
    {

    }


    void Update()
    {
        if (isdeath)
            return;
        float Distanceshot = Vector3.Distance(player.transform.position, transform.position);

      if(Distanceshot<shootattack)
        {
            Shoot(player.transform.position);
        }
    }
    void Shoot(Vector3 target)
    {
        agent.isStopped = true;
        Vector3 dir= target-transform.position;
        anim.SetBool("shot", true);

    }

    public void MoveToDirection(Vector3 direction)
    {
        RotateToDirection(direction);
        agent.Move(transform.forward * speed * Time.deltaTime);
    }
    public void RotateToDirection(Vector3 direction)
    {
        Quaternion targetQuaternion = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, angularSpeed * Time.deltaTime);

    }
}
