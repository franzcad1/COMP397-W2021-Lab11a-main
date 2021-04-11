using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCameraTransform;
    public GameObject playerCamera;

    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera");
        if (playerCamera)
        {
            playerCameraTransform = playerCameraTransform.transform;
        }
        
    }


    void LateUpdate()
    {
        if(playerCameraTransform)
        {
            // billboard the healthBar
            transform.LookAt(transform.position + playerCameraTransform.forward);
        }
     
    }
}
