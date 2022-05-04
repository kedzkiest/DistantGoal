using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeFailure : MonoBehaviour
{
    public static bool failureFlag;
    
    // Start is called before the first frame update
    void Start()
    {
        failureFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            failureFlag = true;
        }
    }
}
