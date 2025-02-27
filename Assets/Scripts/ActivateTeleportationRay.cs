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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHandTeleportation.SetActive(leftHandActivate.action.ReadValue<float>() > 0.1f);
        rightHandTeleportation.SetActive(rightHandActivate.action.ReadValue<float>() > 0.1f);
    }
}
