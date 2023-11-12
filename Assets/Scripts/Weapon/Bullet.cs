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

    [SerializeField] private ParticleSystem Hit;
    //[SerializeField] private ParticleSystem Fire_Rocket;

    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
       
    }

  
    void Update()
    {

        rb.AddForce(transform.forward * moveSpeed);
        //transform.Translate(transform.forward * moveSpeed);

    }
        
    private void OnTriggerEnter(Collider objectother)
    {
        
        ITakeDame dame = objectother.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(objectother.name);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;
        Hit.gameObject.SetActive(true);
        Hit.Play();
        //gameObject.SetActive(false);
        Destroy(gameObject,0.6f);
    }
    IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

       gameObject.SetActive(true);
    }


}
