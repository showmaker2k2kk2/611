using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WtesTrigeer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<TestMove>())
        {
            other.GetComponent<TestMove>().Add(this.gameObject);
        }    
            Debug.Log(other.name);
    }
}
