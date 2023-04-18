using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winston : MonoBehaviour
{
    public Rigidbody winston;
    public BottleClink bottleSounds;
    public Animator _animator;
    public AudioSource sentence1;
    public GameManager _gameManager; 

    private void Start()
    {
        winston = GetComponent<Rigidbody>();
    }
    
    public void LowVolumeSoundReaction()
    {
        if (bottleSounds.clink.volume == 0.89)
        {
            WinstonSpeaks(); 
        }
    }

    private void WinstonSpeaks()
    {
        
        if (_animator != null)
        {
            //sentence1.Play; 
        }
    }
}
