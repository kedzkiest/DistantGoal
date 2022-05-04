using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPlayer : MonoBehaviour
{
    public AudioClip mvOrRotSound;
    public AudioClip switchOperationSound;
    public AudioClip resetSound;
    public AudioClip runSound;

    public AudioClip selectedSound;
    public AudioClip unselectedSound;

    public AudioClip clearSound;
    public AudioClip clearSound2;
    public AudioClip failureSound;

    public PlayerController playerController;

    private AudioSource audioSource;

    public bool isCalledOnce;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        isCalledOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMvOrRotSound()
    {
        if (playerController.isRunning) return;
        
        audioSource.PlayOneShot(mvOrRotSound);
    }
    
    public void PlaySwitchOperationSound()
    {
        if (playerController.isRunning) return;

        audioSource.PlayOneShot(switchOperationSound);
    }
    
    public void PlayResetSound()
    {
        audioSource.PlayOneShot(resetSound);
    }

    public void PlayRunSound()
    {
        audioSource.PlayOneShot(runSound);
    }
    
    public void PlaySelectedSound()
    {
        if (playerController.isRunning) return;

        audioSource.PlayOneShot(selectedSound);
    }
    
    public void PlayUnselectedSound()
    {
        if (playerController.isRunning) return;

        audioSource.PlayOneShot(unselectedSound);
    }
    
    public void PlayClearSound()
    {
        if (!isCalledOnce)
        {
            isCalledOnce = true;
            audioSource.PlayOneShot(clearSound);
            audioSource.PlayOneShot(clearSound2);   
        }
    }
    
    public void PlayFailureSound()
    {
        if (!isCalledOnce)
        {
            isCalledOnce = true;
            audioSource.PlayOneShot(failureSound);
        }
    }

    public void SetIsCalledOnce(bool b)
    {
        isCalledOnce = b;
    }
}
