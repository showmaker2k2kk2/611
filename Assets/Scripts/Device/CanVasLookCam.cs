using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanVasLookCam : MonoBehaviour
{
    public Transform cam;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam.position + cam.forward);
    }
}
