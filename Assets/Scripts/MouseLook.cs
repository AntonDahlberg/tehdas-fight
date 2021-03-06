﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform playerBody;

    float xRotate = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       
        //takes mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;




        //look around ingame
        xRotate -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
        playerBody.Rotate(Vector3.up * mouseX); 
    
    }
}
