//2D Smooth Camera Follow in Unity Tutorial
//Muddy Wolf
// Accessed ; 18 March 2025
//Version 2
//https://youtu.be/8rnRvotQmdg?si=5PZBqpTSvMCcmcVe


using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class cameraFollow : MonoBehaviour


{ [SerializeField] private Vector3 offset; // THe position of the main camera 
    [SerializeField] private float damping; //Controls the follow speed of the camera
    public Transform target; //Who the camera is going to follow 

    private Vector3 vel=Vector3.zero;
   
    void Update()
    {
        Vector3 targetPos = target.position + offset;
        targetPos.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel , damping); 
    }
}
