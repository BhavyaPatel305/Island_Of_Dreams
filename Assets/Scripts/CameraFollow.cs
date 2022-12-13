using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(player);
    }
    
    /*
    void LateUpdate(){
        Vector3 playerPos = player.transform.position;
        transform.LookAt(playerPos);
        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");
        transform.Translate(-turn.x, turn.y, 0);
    }
    */
}