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
    public GameObject projectitleModel;

    bool danvacham;

    [SerializeField] private ParticleSystem Hit;
    //[SerializeField]public ParticleSystem Flash_Rocket;

    Gun Gunn;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
       if(danvacham)
        {
            StartCoroutine(DestroyAfterDelay(1.0f));
        }    
    }

  
    void Update()
    {
 
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Flash_Rocket.gameObject.SetActive(true);
        //    Flash_Rocket.Play();
        //}    
        rb.AddForce(transform.forward * moveSpeed);
        //transform.Translate(transform.forward * moveSpeed);

    }
        
    private void OnTriggerEnter(Collider objectother)
    {
        danvacham = true;
        ITakeDame dame = objectother.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(objectother.name);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;
        projectitleModel.SetActive(false);
        Hit.gameObject.SetActive(true);
        Hit.Play();

        Destroy(gameObject,0.5f);
 
    }
    IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

       gameObject.SetActive(true);
    }


}
