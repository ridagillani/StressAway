using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoorRaycast : MonoBehaviour
{
    
   [SerializeField] private int rayLength = 5;
   [SerializeField] private LayerMask layerMaskInteract;
   [SerializeField] private string excludeLayerName = null;

   private DoorController raycastedObj;
   [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;
   [SerializeField] private Image crosshair = null;
   private bool isCrossHairActive;
   private bool doOnce;
   private const string interactableTag = "InteractiveObject";

   private void Update()
   {
    Cursor.visible = true;
    RaycastHit hit;
    Vector3 fwd = transform.TransformDirection(Vector3.forward);
  
    int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract. value;
    if (Physics. Raycast (transform. position, fwd, out hit, rayLength, mask))
    {
        if ((hit. collider.CompareTag(interactableTag)))
        {
            if(!doOnce)
            {
                raycastedObj = hit.collider.gameObject.GetComponent<DoorController>();
                CrosshairChange(true);
            }

            isCrossHairActive = true;
            doOnce = true;

            if (Input.GetKeyDown(openDoorKey))
            {
                raycastedObj.PlayAnimation();
            }
        }
    }
    else 
    {
        if (isCrossHairActive)
        {
            CrosshairChange(false);
            doOnce = false;
        }
    }
    }

    void CrosshairChange(bool on)
    {
        if (on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrossHairActive = false;
        }
    }
}
