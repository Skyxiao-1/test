//2D Top Down Movement UNITY Tutorial
//BmO
// Accessed : 15 March 2025
// Code Version : 3
//https://youtu.be/u8tot-X_RBI?si=ZbpWg1TD81Oaciuy

//How To Do W A S D Movement In Unity 2D
//MileOnAir
// Accessed : 16 March 2025
// Code Version 2 
//https://youtu.be/jFZvW79mOYE?si=z-DuU-jYUV-4Xzyd
// This is the video where i got the idea to use the CineMachine Tool

//2D Smooth Camera Follow in Unity Tutorial
//Muddy Wolf
// Accessed ; 20 March 2025
//Version 2
//https://youtu.be/8rnRvotQmdg?si=5PZBqpTSvMCcmcVe

using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    public float speed = 10f; //Movement speed of player
    public Rigidbody2D rb; //Player GameObject reference 
    private float vector2; 

    public Camera cam;
    public float camAng = 100f; //The value that controls the angle at which the player will face the mouse cursor the player will be able to aim
    Vector2 mousePos;
    Vector2 movement;

   
    void Update()
    {
       movement.x= Input.GetAxisRaw("Horizontal");
       movement.y= Input.GetAxisRaw("Vertical");

      mousePos =  cam.ScreenToWorldPoint(Input.mousePosition); //tracks the mouse cursor 
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +movement*speed*Time.deltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg + camAng;

        rb.rotation = angle;

    }
}
