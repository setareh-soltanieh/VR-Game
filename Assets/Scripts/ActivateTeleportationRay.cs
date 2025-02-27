using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftHandTeleportation;
    public GameObject rightHandTeleportation;

    public InputActionProperty leftHandActivate;
    public InputActionProperty rightHandActivate;

    // Using these two inputs I am checking whether the grip button is activated or not, the user can only use the teleportation if 
    // the grip button are not activated 
    public InputActionProperty leftHandCancel;
    public InputActionProperty rightHandCancel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHandTeleportation.SetActive(leftHandCancel.action.ReadValue<float>() == 0 && leftHandActivate.action.ReadValue<float>() > 0.1f);
        rightHandTeleportation.SetActive(rightHandCancel.action.ReadValue<float>() == 0 && rightHandActivate.action.ReadValue<float>() > 0.1f);
    }
}
