using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera vcam1;

    public CinemachineVirtualCamera vcam2;

    public CinemachineVirtualCamera vcam3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vcam1_ON()
    {
        vcam1.Priority = 10;
    }

    public void Vcam1_OFF()
    {
        vcam1.Priority = 9;
    }
    
    public void Vcam2_ON()
    {
        vcam2.Priority = 10;
    }

    public void Vcam2_OFF()
    {
        vcam2.Priority = 9;
    }
    
    public void Vcam3_ON()
    {
        vcam3.Priority = 10;
    }

    public void Vcam3_OFF()
    {
        vcam3.Priority = 9;
    }
}
