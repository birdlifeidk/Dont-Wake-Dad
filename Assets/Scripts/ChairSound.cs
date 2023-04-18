using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSound : MonoBehaviour
{
    public GameObject chair;
    public AudioSource squeakyChair;


    private void OnCollisionStay(Collision collision)
    {
        if (gameObject.CompareTag("Interactable"))
        {
            foreach (ContactPoint contact in collision.contacts)
            {

                squeakyChair.Play();
                GameManager.Instance.soundCount++;

            }
        }

        if (collision.relativeVelocity.magnitude > .7)
        {
            squeakyChair.volume = .89f; 
        }
    }
    
    

   
}
