using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairCreaking : MonoBehaviour
{
    public GameObject stairTrigger;
    public AudioSource smallCreak;

    public void Start()
    {
        Invoke("DelaySound", 0.1f);
    }

    public void DelaySound()
    {
        smallCreak.enabled = true;
    }


    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            smallCreak.Play();
            GameManager.Instance.soundCount++;
        }
    }
}
