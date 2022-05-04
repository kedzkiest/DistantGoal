using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI successText;
    public TextMeshProUGUI failureText;
    
    public float minMoveDist;
    public float minRotAngle;
    private GameObject[] selectedCubes = new GameObject[10];

    public PlayerController playerController;

    // 1 for Move operation, 2 for Rotate operation
    public int OperationMode;

    public SEPlayer sePlayer;

    public GameObject[] DisabledOnRunning = Array.Empty<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        OperationMode = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (JudgeClear.clearFlag && JudgeFailure.failureFlag)
        {
            successText.enabled = false;
            failureText.enabled = true;
            sePlayer.PlayFailureSound();
        }
        else
        {
            if (JudgeClear.clearFlag)
            {
                successText.enabled = true;
                sePlayer.PlayClearSound();
            }
            else
            {
                successText.enabled = false;
            }

            if (JudgeFailure.failureFlag)
            {
                failureText.enabled = true;
                sePlayer.PlayFailureSound();
            }
            else
            {
                failureText.enabled = false;
            }
        }
    }

    public void X_Plus()
    {
        if (playerController.isRunning) return;
        
        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(minMoveDist, 0, 0);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(minRotAngle, 0, 0);
            }
        }
    }
    
    public void X_Minus()
    {
        if (playerController.isRunning) return;

        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(-minMoveDist, 0, 0);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(-minRotAngle, 0, 0);
            }
        }
    }
    
    public void Y_Plus()
    {
        if (playerController.isRunning) return;

        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(0, minMoveDist, 0);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(0, minRotAngle, 0);
            }
        }
    }
    
    public void Y_Minus()
    {
        if (playerController.isRunning) return;

        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(0, -minMoveDist, 0);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(0, -minRotAngle, 0);
            }
        }
    }
    
    public void Z_Plus()
    {
        if (playerController.isRunning) return;

        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(0, 0, minMoveDist);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(0, 0, minRotAngle);
            }
        }
    }
    
    public void Z_Minus()
    {
        if (playerController.isRunning) return;

        selectedCubes = GameObject.FindGameObjectsWithTag("Selected");

        if (OperationMode == 1)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.position = go.transform.position + new Vector3(0, 0, -minMoveDist);
            }
        }
        else if (OperationMode == 2)
        {
            foreach (GameObject go in selectedCubes)
            {
                go.transform.Rotate(0, 0, -minRotAngle);
            }
        }
    }

    public void SetOperationMode(int op)
    {
        OperationMode = op;
    }

    public void DisableUI()
    {
        foreach (GameObject go in DisabledOnRunning)
        {
            go.SetActive(false);
        }
    }

    public void EnableUI()
    {
        foreach (GameObject go in DisabledOnRunning)
        {
            go.SetActive(true);
        }
    }
}
