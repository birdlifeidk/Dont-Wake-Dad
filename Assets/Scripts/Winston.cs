using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winston : MonoBehaviour
{
    public Rigidbody winston;
    public BottleClink bottleSounds;
    public Animator _animator; 

    private void Start()
    {
        winston = GetComponent<Rigidbody>();
    }
    
    public void LowVolumeSoundReaction()
    {
        if (bottleSounds.clink.volume == 0.89)
        {
            WinstonAwakens();
        }
    }

    private void WinstonAwakens()
    {
        
        if (_animator != null)
        {
         //   _animator.SetTrigger();	
        }
    }
}
