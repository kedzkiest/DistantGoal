using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_ControllRigidbody : MonoBehaviour
{
    private PlayerController playerController;

    private bool isCalledOnce;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        isCalledOnce = false;
        rb = GetComponent<Rigidbody>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isRunning)
        {
            rb.useGravity = true;
        }

        if (rb.velocity == Vector3.zero && !isCalledOnce)
        {
            isCalledOnce = true;
            rb.useGravity = false;
        }
        if (!rb.useGravity)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
