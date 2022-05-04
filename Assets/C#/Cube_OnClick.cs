using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_OnClick : MonoBehaviour
{
    private PlayerController playerController;
    
    private bool isSelected;

    private SEPlayer sePlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        sePlayer = GameObject.FindGameObjectWithTag("SEPlayer").GetComponent<SEPlayer>();
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isRunning)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void OnClick()
    {
        isSelected = !isSelected;

        if (isSelected)
        {
            gameObject.tag = "Selected";
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            sePlayer.PlaySelectedSound();
        }
        else
        {
            gameObject.tag = "Untagged";
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            sePlayer.PlayUnselectedSound();
        }
    }
}
