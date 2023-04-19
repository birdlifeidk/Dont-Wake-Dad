using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSound : MonoBehaviour
{
    public GameObject chair;
    public AudioSource squeakyChair;


 
        public void Start()
        {
            Invoke("DelaySound", 0.1f);
        }

        public void DelaySound()
        {
            squeakyChair.enabled = true;
        }
        public void OnCollisionEnter(Collision collision)
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                squeakyChair.Play();
                GameManager.Instance.soundCount++;
            }

            if (collision.relativeVelocity.magnitude > .9)
            {
                squeakyChair.volume = .6f; 
            }

            if (collision.relativeVelocity.magnitude == 0f)
            {
                squeakyChair.volume = 0f; 
            }
    }
    
    

   
}
