    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject[] waypoint;
    int currentpointindex = 0;
    float speed = 10;
     

    void Update()
    {

      if(Vector3.Distance(transform.position,waypoint[currentpointindex].transform.position)<.1)
        {
            currentpointindex++;
            if(currentpointindex>=waypoint.Length)
            {
                currentpointindex = 0;
            }    
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoint[currentpointindex].transform.position, speed * Time.deltaTime);
    }
}
