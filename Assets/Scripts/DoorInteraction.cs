using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public int objectsCollected;
    public int objectsNeeded;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        objectsCollected = 0;
        objectsNeeded = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (objectsCollected == objectsNeeded)
        {
            door.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Collectable")
        {
            objectsCollected++;
            Debug.Log("mmm chips");

            // Deactivate the collectible so it cannot be collected again.
            Col.gameObject.SetActive(false);   
        }
        
    }

    public void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "WinDoor")
        {
            FindObjectOfType<MenuManager>().WinGame();
        }
    }
}
