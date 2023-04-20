using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Cinemachine;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Object = UnityEngine.Object;


public class PickUpSnack : MonoBehaviour
{ 
    [SerializeField] private LayerMask PickUpLayer; 
    [SerializeField] private Camera PlayerCamera; 
    [SerializeField] private float PickUpRange;
    [SerializeField] private Transform Hand;
    
    
    private Rigidbody chipRigidbody;
    private Collider chipCollider;
    public GameObject pickUpWindow;

    private void Start()
    {
        pickUpWindow.SetActive(true);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
           
            Ray PickUpRay = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);

            if (Physics.Raycast(PickUpRay, out RaycastHit hitInfo, PickUpRange, PickUpLayer))
            {
                
                if (chipRigidbody)
                {
                
                }
                else
                {
                    chipRigidbody = hitInfo.rigidbody;
                    chipCollider = hitInfo.collider;

                    chipRigidbody.isKinematic = true;
                    chipCollider.enabled = false; 
                }
            }
        }

        if (chipRigidbody)
        {
            chipRigidbody.position = Hand.position;
            chipRigidbody.rotation = Hand.rotation; 
        }
        
      


    }

    private void OnTriggerExit(Collider other)
    {
        pickUpWindow.SetActive(false);
    }
}
