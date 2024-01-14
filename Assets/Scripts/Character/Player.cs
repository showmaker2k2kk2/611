using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Emity
{
    public float speed;
    private float ho;
    private float ve;

    public CanvasHealth canVasHealth;
    //public int starthealth = 100;
    public int currentHealth;
    public PlayerState chi_so_so_player;


    Rigidbody rb;   
    Animator anim;
    [SerializeField] float jumpForce;


   


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        //animator.Initialized();
       

    }
    protected override void Start()
    {
        base.Start();
        currentHealth = chi_so_so_player.StartHealth; /*starthealth*/
        canVasHealth.setUpMaxHealth(currentHealth);
    }


    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);
        //rb.MovePosition(transform.position + movement);
            
        
        
        
        
        
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //}


        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 dir = new Vector3(horizontal, 0, vertical);
        //LookMouse();
        //if (dir != Vector3.zero)
        //{
        //    anim.SetBool("Run", true);
        //    //animator.SetMovement(characterAnimator.Movementtype.Run);
        //    //Debug.LogError("AAA");
        //    MoveInput(dir);

        //}
        //else
        //{
        //    //animator.SetMovement(characterAnimator.Movementtype.idle);
        //    anim.SetBool("Run", false);
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //}
    }

    internal void Takedame(int v)
    {
        throw new NotImplementedException();
    }

    void MoveInput(Vector3 dirMove)
    {
        agent.Move(dirMove * speed * Time.deltaTime);
       
    }
   
        void LookMouse()
        {
            RaycastHit hit;
            Ray
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
  

}
