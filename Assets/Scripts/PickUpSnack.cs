using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using Object = UnityEngine.Object;


public class PickUpSnack : MonoBehaviour
{ 
    [SerializeField] private LayerMask PickUpLayer; 
    [SerializeField] private Camera PlayerCamera; 
    [SerializeField] private float PickUpRange;
    [SerializeField] private Transform Hand; 
    
    private Rigidbody chipRigidbody;
    private Collider chipCollider; 

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
}
