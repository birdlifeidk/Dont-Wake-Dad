using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSnack : MonoBehaviour
{

    public GameObject SnacksEquipped; 
    void Start()
    {
        SnacksEquipped.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                SnacksEquipped.SetActive(true);
            }
        }
    }
}
