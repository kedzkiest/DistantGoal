using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    public AudioClip normalBGM;

    public AudioClip runningBGM;

    private AudioSource audioSource;

    public PlayerController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNormalBGM()
    {
        if (audioSource.clip == normalBGM) return;
        
        audioSource.clip = normalBGM;
        audioSource.Play();
    }

    public void PlayRunningBGM()
    {
        audioSource.clip = runningBGM;
        audioSource.Play();
    }
}
