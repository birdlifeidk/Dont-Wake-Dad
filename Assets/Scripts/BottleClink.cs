using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleClink : MonoBehaviour
{
    //Will add the OnCollision actions with the different objects
    //This will also need to interact with the Winston script. For example, if Johnny's moves exceed a certain volume, it will trigger Winston's character script and wake him up. 
    //Also add the grab functions so that he can interact with the world. 
    public Rigidbody johny;
    public GameObject beerBottle;
    public AudioSource clink; 

    public void Start()
    {
        johny = GetComponent<Rigidbody>(); 
    }

    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            clink.Play();
        }

        if (collision.relativeVelocity.magnitude > 1)
        {
            clink.volume = .89f; 
        }
    }
}
