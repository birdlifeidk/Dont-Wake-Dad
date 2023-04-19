using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalClank : MonoBehaviour
{
    public GameObject pot;
    public AudioSource metalClank;

    public void Start()
    {
        Invoke("DelaySound", 1f);
    }

    public void DelaySound()
    {
        metalClank.enabled = true;
    }


    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            metalClank.Play();
            GameManager.Instance.soundCount++;
        }
        if (collision.relativeVelocity.magnitude > .9)
        {
            metalClank.volume = .50f; 
        }
    }
}
